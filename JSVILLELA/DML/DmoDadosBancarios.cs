using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVILLELA.DML
{
    /// <summary>
    /// Classe DML para Dados Bancários
    /// </summary>
    public class DmoDadosBancarios
    {
        #region Propriedades
        public int IdDadosBancarios { get; set; }

        public string Banco { get; set; }

        public string Agencia { get; set; }

        public TiposDeConta TipoDeConta;

        public string Conta { get; set; }
        #endregion

        public enum TiposDeConta
        {
            [Description("Conta Poupança")]
            Poupanca,

            [Description("Conta Corrente")]
            Corrente
        }
    }
}
