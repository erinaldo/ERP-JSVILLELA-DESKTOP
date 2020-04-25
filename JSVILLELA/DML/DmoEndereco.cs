using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVILLELA.DML
{
    /// <summary>
    /// Classe DML para Endereço
    /// </summary>
    public class DmoEndereco : DmoBase
    {
        #region Propriedades
        public int IdEndereco { get; set; }

        public int Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Complemento { get; set; }
        #endregion
    }
}
