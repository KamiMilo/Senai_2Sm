using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface IInstituicaoRepository
    {
        void cadastrar(Instituicao novaInstituicao);

        List<Instituicao> Listar();

        void Deletar(Guid id);
    }
}
