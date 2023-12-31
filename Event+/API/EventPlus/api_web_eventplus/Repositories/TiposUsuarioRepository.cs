﻿using apiweb_eventplus.Contexts;
using apiweb_eventplus.Domains;
using apiweb_eventplus.Interfaces;

namespace apiweb_eventplus.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _eventContext;
        public TiposUsuarioRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {
            TiposUsuario usuarioBuscado = _eventContext.TiposUsuario.Find(id)!;

            if (usuarioBuscado != null)
            {
                usuarioBuscado.IdTipoUsuario = id;
            }

            _eventContext.TiposUsuario.Update(usuarioBuscado);


            _eventContext.SaveChanges();

        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            return _eventContext.TiposUsuario.FirstOrDefault(u => u.IdTipoUsuario == id)!;
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();
        }
     
     
        public void Deletar(Guid id)
        {
           TiposUsuario tipoBuscado = _eventContext.TiposUsuario.Find(id)!;

            _eventContext.TiposUsuario.Remove(tipoBuscado);

            _eventContext.SaveChanges();


        }


        public List<TiposUsuario> Listar()
        {
            return _eventContext.TiposUsuario.ToList();
        }
    }
}
