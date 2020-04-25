using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVILLELA.DML
{
    /// <summary>
    /// Classe DML para Login
    /// </summary>
    class DmoLogin : DmoBase
    {
        #region Propriedades
        public string Usuario { get; set; }

        public string Senha { get; set; }

        public NiveisDeAcesso NivelDeAcesso { get; set; }

        public DmoFuncionario Funcionario { get; set; }
        #endregion

        public enum NiveisDeAcesso
        {
            Administrador,

            Funcionario
        }
    }
}
