using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;

namespace apiweb_eventplus.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {
        private readonly EventContext _ctx;

        public TiposEventoRepository()
        {
            _ctx= new EventContext();
        }
        public void Atualizar(Guid id, TiposEvento TiposEvento)
        {
            TiposEvento TipoEventoBuscado = _ctx.TiposEvento.Find(id);

            if(TipoEventoBuscado != null)
            {
                TipoEventoBuscado.IdTipoEvento = id;
            }

            _ctx.TiposEvento.Update(TipoEventoBuscado);

            _ctx.SaveChanges();
        }

        public TiposEvento BuscarPorId(Guid id)
        {
            return _ctx.TiposEvento.FirstOrDefault(U => U.IdTipoEvento == id);
        }

        public void Cadastrar(TiposEvento novoTipoDeEvento)
        {
            _ctx.TiposEvento.Add(novoTipoDeEvento);

            _ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposEvento TipoEventoBuscado = _ctx.TiposEvento.Find(id);

            _ctx.TiposEvento.Remove(TipoEventoBuscado);

            _ctx.SaveChanges();
        }

        public List<TiposEvento> Listar()
        {
            return _ctx.TiposEvento.ToList();
        }
    }
}
