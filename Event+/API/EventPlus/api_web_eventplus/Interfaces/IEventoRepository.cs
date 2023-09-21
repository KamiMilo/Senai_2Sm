using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastrar(Evento novoEvento);

        List<Evento> Listar();

        void Deletar(Guid id);


        void Atualizar(Evento Evento, Guid id);

        Evento BuscarPorId(Guid id);
    }
}
