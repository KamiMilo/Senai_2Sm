using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface IPresencasEventoRepository
    {

        void Cadastrar(PresencasEvento presenca);


        void Deletar(Guid id);


        void Atualizar(PresencasEvento confirmacao,Guid id);

        List<PresencasEvento>ListarMinhas(Guid id);
    }
}
