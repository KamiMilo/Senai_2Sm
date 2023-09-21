using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface IPresencasEvento
    {

        void Cadastrar(PresencasEvento presenca);


        void Deletar(Guid id);


        void Atualizar(PresencasEvento Evento,Guid id);

        List<PresencasEvento>ListarMinhas(Guid id);
    }
}
