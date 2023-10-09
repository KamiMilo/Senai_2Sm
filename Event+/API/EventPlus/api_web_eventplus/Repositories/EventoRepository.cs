using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using Microsoft.EntityFrameworkCore.Query;

namespace apiweb_eventplus.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _ctx;

        public EventoRepository()
        {
            _ctx = new EventContext();
        }

        public void Atualizar(Evento Evento, Guid id)
        {
            Evento eventoBuscado = _ctx.Evento.Find(id);

            if (eventoBuscado != null) 
            {
                eventoBuscado.IdEvento= id;
            }

            _ctx.Evento.Update(eventoBuscado);

            _ctx.SaveChanges();
        }

        public Evento BuscarPorId(Guid id)
        {
            return _ctx.Evento.FirstOrDefault(u => u.IdEvento == id);
        }

        public void Cadastrar(Evento novoEvento)
        {
            Evento.Evento = Guid.NewGuid();
            
            _ctx.Evento.Add(novoEvento);

            _ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Evento eventoBuscado = _ctx.Evento.Find(id);

            _ctx.Evento.Remove(eventoBuscado);

            _ctx.SaveChanges();

        }

        public List<Evento> Listar()
        {
             return _ctx.Evento.ToList();
        }
    }
}
