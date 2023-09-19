using apiweb_eventplus.Domains;
using Microsoft.EntityFrameworkCore;

namespace apiweb_eventplus.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TiposEvento> TiposEvento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<ComentariosEvento> ComentariosEvento { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<PresencasEvento> PresencasEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= NOTE07-S14; Database= apiweb_event+; user id= sa; pwd= Senai@134; TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
