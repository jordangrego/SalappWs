using SalappWs.Entidade;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SalappWs
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SalappWs : ISalappWs
    {
        
        public void DoWork(string id)
        {
            Debug.WriteLine("id: " + id);
        }

        
        public Produto RecuperaProduto()
        {
            return new Produto() { CodProduto = 1, NomeProduto = "Meu Produto" };
        }
    }
}
