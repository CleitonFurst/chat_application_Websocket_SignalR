using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Blue.Models
{

    //criação da tabela do chat 
    public class Message
    {
        public int Id { get; set; }//id da mensagem
        public string  UserName { get; set; }//nome do usuario que mandou a mensagem
        public string  TargetName { get; set; }
        [Required]
        public string Text { get; set; }// mensagem
        public DateTime Datetime { get; set; }
        public string UserId { get; set; }//vai servir para se conectar com a tabela AppUser
        public AppUser appUser { get; set; }//(chave estranjeira)para fazer vinculo com a tabla que vai conter as informações do usúario e das mensagens 
        public string targetId { get; set; }
        public AppUser targetUser { get; set; }

    }
}
