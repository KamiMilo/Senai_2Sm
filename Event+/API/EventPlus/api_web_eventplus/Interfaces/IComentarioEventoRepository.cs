using apiweb_eventplus.Domains;

namespace apiweb_eventplus.Interfaces
{
    public interface IComentarioEventoRepository
    {
        void Comentario(ComentariosEvento novoComentario);

        List<ComentariosEvento> Listar();

    }
}
