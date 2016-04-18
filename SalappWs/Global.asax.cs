using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.ServiceModel.Activation;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using SalappWs.Util;
using SalappWs.Entidade;

namespace SalappWs
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute("usuario", new WebServiceHostFactory(), typeof(UsuarioWs)));
            RouteTable.Routes.Add(new ServiceRoute("salapp", new WebServiceHostFactory(), typeof(SalappWs)));


            string pathArquivoBase = AppDomain.CurrentDomain.BaseDirectory + "\\Base.xml";

            // verifica se existe o arquivo no local
            if (!File.Exists(pathArquivoBase))
            {
                Dados dados = new Dados();
                dados.ListaProdutos = new List<Produto>();
                dados.ListaUsuarios = new List<Usuario>();
                UtilDados.GravarDados(dados, pathArquivoBase);
            }
        }

        protected void EnableCrossDomainAjaxCall()
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");

            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Authorization, Accept");
                HttpContext.Current.Response.End();
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            this.EnableCrossDomainAjaxCall();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}