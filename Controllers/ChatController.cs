using Chat_Blue.Data;
using Chat_Blue.Hubs;
using Chat_Blue.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Blue.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        public readonly UserManager<AppUser> _userManager;//instanciar o objeto do tipo UserManager
        public readonly Context _context;//instancia o contexte dentro do controller
        public ChatController(UserManager<AppUser> userManager, Context context)//construtor
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> PrivateMessage(string id)
        {
            var current = await _userManager.GetUserAsync(User);//traz o usaurio atual
            var target = await _userManager.FindByNameAsync(id);
            var sentMessages = _context.Message.Where(m => m.UserName == current.UserName && m.TargetName == target.UserName).ToList();
            var receivedMessages = _context.Message.Where(m => m.UserName == target.UserName && m.TargetName == current.UserName).ToList();
            var messages = sentMessages.Concat(receivedMessages).ToList();
            ViewBag.Messages = messages;//passa as mensagens refentes ao usuarario logado
            ViewBag.CurrentUser = current;
            ViewBag.TargetUser = target;
            return View();
        }
        public async Task<IActionResult> Private()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            List<IdentityUser> allUsers = _context.Users.Where(u => u.UserName != currentUser.UserName).ToList();
            return View(allUsers);
        }
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);           
            ViewBag.CurrentUserName = currentUser.UserName;
            ViewBag.Messages = _context.Message.Where(m => m.TargetName == null).ToList();
            return View();
        }
        public async Task<IActionResult> SendMessage(string Text, [FromServices] IHubContext<ChatHub> chat)
        {

            if (Text != null) { 
                var sender = await _userManager.GetUserAsync(User);
                Message message = new Message
                {
                    Text = Text,
                    UserName = User.Identity.Name,
                    UserId = sender.Id,
                    Datetime = DateTime.Now
                };
           
                _context.Message.Add(message);
                _context.SaveChanges();
                await chat.Clients.All.SendAsync("RecieveMessage", message); 
            }
            return Ok();
        }
    }
}
