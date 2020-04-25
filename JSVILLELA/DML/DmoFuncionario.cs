using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVILLELA.DML
{
    /// <summary>
    /// Classe DML para Funcionário
    /// </summary>
    public class DmoFuncionario : DmoBase
    {
        #region Propriedades
        public int IdFuncionario { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public DmoEndereco Endereco { get; set; }

        public DmoDadosBancarios DadosBancarios { get; set; }
        #endregion
    }
}
