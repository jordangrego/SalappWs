using SalappWs.Entidade;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SalappWs
{
    [ServiceContract]
    public interface IUsuarioWs
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Recuperar/{codUsuario}", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        Usuario Recuperar(string codUsuario);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Listar", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> Listar();

        [OperationContract]
        [WebInvoke(UriTemplate = "/Pesquisar", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> Pesquisar(Usuario usuario);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Inserir", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        void Inserir(Usuario usuario);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Alterar", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        void Alterar(Usuario usuario);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Excluir/{codUsuario}", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        void Excluir(string codUsuario);
    }
}
