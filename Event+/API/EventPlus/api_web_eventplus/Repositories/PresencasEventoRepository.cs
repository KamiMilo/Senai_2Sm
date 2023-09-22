using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;
using System.Reflection.Metadata;

namespace apiweb_eventplus.Repositories
{
    public class PresencasEventoRepository : IPresencasEventoRepository
    {
        private readonly EventContext _ctx;
        public void Atualizar(PresencasEvento confirmacao , Guid id)
        {
            PresencasEvento presencaBuscada = _ctx.PresencasEvento.Find(id);

            if (presencaBuscada != null)
            {           
                presencaBuscada.IdPresencasEvento= id;
            }
            _ctx.PresencasEvento.Update(presencaBuscada);

            _ctx.SaveChanges();
        }

        public void Cadastrar(PresencasEvento presenca)
        {
            _ctx.PresencasEvento.Add(presenca);

            _ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            PresencasEvento presencaBuscada = _ctx.PresencasEvento.Find(id);

            _ctx.PresencasEvento.Remove(presencaBuscada);

            _ctx.SaveChanges();
        }

        public List<PresencasEvento> ListarMinhas(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
