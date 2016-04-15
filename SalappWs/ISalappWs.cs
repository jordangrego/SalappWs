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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalappWs" in both code and config file together.
    [ServiceContract]
    public interface ISalappWs
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/DoWork/{id}", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        void DoWork(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RecuperaProduto", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        Produto RecuperaProduto();
    }
}
