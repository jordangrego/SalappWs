using SalappWs.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SalappWs
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuario" in both code and config file together.
    [ServiceContract]
    public interface IUsuarioWs
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Recuperar/{id}", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        void Recuperar(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Listar", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> Listar();

        [OperationContract]
        [WebInvoke(UriTemplate = "/Inserir", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        void Inserir(Usuario usuario);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Alterar", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        void Alterar(Usuario usuario);
    }
}
