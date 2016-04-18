using SalappWs.Entidade;
using SalappWs.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalappWs.Negocio
{
    public class UsuarioBll
    {
        /// <summary>
        /// Altera Usuário.
        /// </summary>
        /// <param name="usuario"></param>
        public void Alterar(Usuario usuario)
        {
            Dados dados = UtilDados.RecuperarBase();
            List<Usuario> lista = dados.ListaUsuarios;
            Usuario usuarioAlt = lista.Where(x => x.CodUsuario == usuario.CodUsuario).FirstOrDefault<Usuario>();

            if (usuarioAlt != null)
            {
                usuarioAlt.NomeUsuario = usuario.NomeUsuario;
            }

            UtilDados.GravarDados(dados);
        }

        /// <summary>
        /// Insere Usuário.
        /// </summary>
        /// <param name="usuario"></param>
        public void Inserir(Usuario usuario)
        {
            Dados dados = UtilDados.RecuperarBase();
            dados.ListaUsuarios.Add(usuario);
            UtilDados.GravarDados(dados);
        }

        /// <summary>
        /// Exclui usuário.
        /// </summary>
        /// <param name="codUsuario"></param>
        public void Excluir(int codUsuario)
        {
            Dados dados = UtilDados.RecuperarBase();
            dados.ListaUsuarios.RemoveAll(x => x.CodUsuario ==codUsuario);
            UtilDados.GravarDados(dados);
        }

        /// <summary>
        /// Lista todos usuarios.
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Listar()
        {
            return UtilDados.RecuperarBase().ListaUsuarios;
        }

        /// <summary>
        /// Pesquisa usuários.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Usuario> Pesquisar(Usuario usuario)
        {
            List<Usuario> lista = UtilDados.RecuperarBase().ListaUsuarios;

            if (usuario.CodUsuario > 0)
            {
                lista = lista.Where(x => x.CodUsuario == usuario.CodUsuario).ToList<Usuario>();
            }

            if (usuario.NomeUsuario != null && usuario.NomeUsuario.Equals(string.Empty))
            {
                lista = lista.Where(x => x.NomeUsuario.ToUpper().Contains(usuario.NomeUsuario.ToUpper())).ToList<Usuario>();
            }

            return lista;
        }

        /// <summary>
        /// Recupera Usuariuos
        /// </summary>
        /// <param name="codUsuario"></param>
        /// <returns></returns>
        public Usuario Recuperar(int codUsuario)
        {
            List<Usuario> lista = UtilDados.RecuperarBase().ListaUsuarios;
            Usuario usuario = lista.Where(x => x.CodUsuario == codUsuario).FirstOrDefault<Usuario>();
            return usuario;
        }
    }
}