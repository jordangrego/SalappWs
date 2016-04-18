using SalappWs.Entidade;
using SalappWs.Enums;
using SalappWs.Exception;
using System;
using System.IO;
using System.Xml.Serialization;

namespace SalappWs.Util
{
    public static class UtilDados
    {
        public static Dados RecuperaBase(byte[] arquivo)
        {
            try
            {
                // Realiza a importação.
                Dados dados = new Dados();
                XmlSerializer x = new XmlSerializer(dados.GetType());
                Stream stream = new MemoryStream(arquivo);
                StreamReader leitor = new StreamReader(stream);

                dados = (Dados)x.Deserialize(leitor);
                leitor.Close();
                return dados;
            }
            catch (System.Exception)
            {
                throw new SalappException(SalappEnumErro.ERRO_LEITURA_BASE);
            }
        }

        public static void GravarDados(Dados dados, string pathArquivo)
        {
            XmlSerializer x = new XmlSerializer(dados.GetType());
            StreamWriter escritor = new StreamWriter(pathArquivo);
            x.Serialize(escritor, dados);
            escritor.Close();
        }

        public static void GravarDados(Dados dados)
        {
            string pathArquivoBase = AppDomain.CurrentDomain.BaseDirectory + "\\Base.xml";
            XmlSerializer x = new XmlSerializer(dados.GetType());
            StreamWriter escritor = new StreamWriter(pathArquivoBase);
            x.Serialize(escritor, dados);
            escritor.Close();
        }

        public static Dados RecuperarBase()
        {
            string pathArquivoBase = AppDomain.CurrentDomain.BaseDirectory + "\\Base.xml";

            FileStream fs = null;
            try
            {
                fs = File.OpenRead(pathArquivoBase);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return RecuperaBase(bytes);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }

        }
    }
}