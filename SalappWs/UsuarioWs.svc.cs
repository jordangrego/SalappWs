using SalappWs.Entidade;
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
        public void Alterar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Usuario usuario)
        {
            Dados dados = UtilDados.RecuperarBase();
            dados.ListaUsuarios.Add(usuario);
            UtilDados.GravarDados(dados);
        }

        public List<Usuario> Listar()
        {
            return UtilDados.RecuperarBase().ListaUsuarios;
        }

        public void Recuperar(string id)
        {
            throw new NotImplementedException();
        }
    }
}
