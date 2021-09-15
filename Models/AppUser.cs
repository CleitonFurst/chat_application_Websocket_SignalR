using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

// esta classe foi criada para poder vincular uma lida de mensagens a um determinado usuario autenticado que é relativa a esse usuario
namespace Chat_Blue.Models
{
    public class AppUser : IdentityUser//herda todos os atributos do usúario da classe IdentityUser
    {
        //guarda uma lista das mensagem enviadas pelo usuario determinado
        public List<Message> Messages { get; set; }//apenas acressentar uma lista de mesnagens referentes aquele usúario
    }
}
