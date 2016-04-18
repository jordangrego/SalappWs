using SalappWs.Enums;
using SalappWs.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalappWs.Exception
{
    public class SalappException : System.Exception
    {
        /// <summary>
        /// Construtor simples desta Exception.
        /// </summary>
        public SalappException()
        {
        }

        /// <summary>
        /// Construtor passando a mensagem de erro.
        /// </summary>
        /// <param name="message">Mensagem desta Exception.</param>
        public SalappException(string message) : base(message)
        {
        }

        /// <summary>
        /// Construtor passando a mensagem de erro e uma Exception interna..
        /// </summary>
        /// <param name="message">Mensagem desta Exception.</param>
        /// <param name="innerException">Exception interna.</param>
        public SalappException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        public SalappException(SalappEnumErro salappEnumErro)
            : this(RecuperaMensagemErro(salappEnumErro))
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        /// <param name="descricaoErro">Campo de Validação.</param>
        public SalappException(SalappEnumErro salappEnumErro, string descricaoErro)
            : this(RecuperaMensagemErro(salappEnumErro, descricaoErro))
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro e outra Exception.
        /// </summary>
        /// <param name="srcoEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        /// <param name="innerException">Exception interna.</param>
        public SalappException(SalappEnumErro salappEnumErro, System.Exception innerException)
            : this(RecuperaMensagemErro(salappEnumErro), innerException)
        {
        }

        /// <summary>
        /// Construtor passando o Domínio de Erro e outra Exception.
        /// </summary>
        /// <param name="salappEnumErro">Dominio de Erro utilizado para lançar essa Exception.</param>
        /// <param name="descricaoErro">Campo de Validação.</param>
        /// <param name="innerException">Exception interna.</param>
        public SalappException(SalappEnumErro salappEnumErro, string descricaoErro, System.Exception innerException)
            : this(RecuperaMensagemErro(salappEnumErro, descricaoErro), innerException)
        {
        }

        /// <summary>
        /// Recupera a descrição do Domínio de Erro.
        /// </summary>
        /// <param name="value">DominioErro para recuperar a descrição.</param>
        /// <returns>Descrição do Domínio de Erro.</returns>
        private static string RecuperaMensagemErro(Enum value)
        {
            return MensagensErro.ResourceManager.GetString(Enum.GetName(typeof(SalappEnumErro), value));
        }

        /// <summary>
        /// Recupera a descrição do Domínio de Erro.
        /// </summary>
        /// <param name="value">DominioErro para recuperar a descrição.</param>
        /// <param name="descricaoErro">Campo de Validação.</param>
        /// <returns>Descrição do Domínio de Erro.</returns>
        private static string RecuperaMensagemErro(Enum value, string descricaoErro)
        {
            return MensagensErro.ResourceManager.GetString(Enum.GetName(typeof(SalappEnumErro), value)) + " : " + descricaoErro;
        }
    }
}