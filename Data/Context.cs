using Chat_Blue.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Chat_Blue.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }//construtor
       
        //como esta sendo usado o IdentityUser indiretamente tem que se acresentar a relação das tabelas
        protected override void OnModelCreating(ModelBuilder builder)//configuração para mostrar o relacionamento entre mensagem e as tabelas do IdentityUser
        {
            base.OnModelCreating(builder);//para colocar informa~ções adicionais
            builder.Entity<Message>()//informações adicionais 
                .HasOne<AppUser>(a => a.appUser)//o usuario
                .WithMany(d => d.Messages)//se realcione com muitas mensagesn
                .HasForeignKey(d => d.UserId);//(chave estrangeira)   atravez de uma chave estrangeira UserId
        }
        public DbSet<Message> Message { get; set; }//para adicioar ao contexto 
    }
}
