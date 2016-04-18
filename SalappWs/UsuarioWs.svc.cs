using SalappWs.Entidade;
using SalappWs.Negocio;
using SalappWs.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SalappWs
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Usuario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Usuario.svc or Usuario.svc.cs at the Solution Explorer and start debugging.
    public class UsuarioWs : IUsuarioWs
    {
        /// <summary>
        /// Altera usuario.
        /// </summary>
        /// <param name="usuario"></param>
        public void Alterar(Usuario usuario)
        {
            new UsuarioBll().Alterar(usuario);
        }

        /// <summary>
        /// Insere usuario.
        /// </summary>
        /// <param name="usuario"></param>
        public void Inserir(Usuario usuario)
        {
            new UsuarioBll().Inserir(usuario);
        }

        /// <summary>
        /// Exclui usuario.
        /// </summary>
        /// <param name="codUsuario"></param>
        public void Excluir(string codUsuario)
        {
            new UsuarioBll().Excluir(Convert.ToInt32(codUsuario));
        }

        /// <summary>
        /// Lista todos usuarios.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Listar()
        {
            return new UsuarioBll().Listar();
        }

        /// <summary>
        /// Pesquisa usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Usuario> Pesquisar(Usuario usuario)
        {
            return new UsuarioBll().Pesquisar(usuario);
        }

        /// <summary>
        /// Recupera usuarios.
        /// </summary>
        /// <param name="codUsuario"></param>
        /// <returns></returns>
        public Usuario Recuperar(string codUsuario)
        {
            return new UsuarioBll().Recuperar(Convert.ToInt32(codUsuario));
        }
    }
}
