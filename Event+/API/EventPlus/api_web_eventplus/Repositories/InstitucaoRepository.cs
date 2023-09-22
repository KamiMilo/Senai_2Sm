using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;

namespace apiweb_eventplus.Repositories
{
    public class InstitucaoRepository : IInstituicaoRepository
    {
        private readonly EventContext _ctx;

        public InstitucaoRepository()
        { 
            _ctx = new EventContext();
        }
        public void cadastrar(Instituicao novaInstituicao)
        {
          _ctx.Instituicao.Add(novaInstituicao);

            _ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Instituicao InstituicaoBuscada = _ctx.Instituicao.Find(id);

            _ctx.Instituicao.Remove(InstituicaoBuscada);

            _ctx.SaveChanges();

        }

        public List<Instituicao> Listar()
        {
            return _ctx.Instituicao.ToList();
        }
    }
}
