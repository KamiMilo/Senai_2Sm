using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface ITiposEventoRepository
    {
        void Cadastrar(TiposEvento novoTipoDeEvento);

        void Deletar(Guid id);

        List<TiposEvento> Listar();

        TiposEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposEvento TiposEvento);
    }
}
