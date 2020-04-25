using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVILLELA.DML
{
    /// <summary>
    /// Clase DML base para todas as classes DML
    /// </summary>
    public class DmoBase
    {
        #region Propriedades
        /// <summary>
        /// Indica se o registro está ativo
        /// </summary>
        public bool Ativo { get; set; }

        /// <summary>
        /// Data de criação do registro
        /// </summary>
        public DateTime DtCriacao { get; set; }

        /// <summary>
        /// Data da última atualização do registro
        /// </summary>
        public DateTime DtAtualizacao { get; set; }
        #endregion
    }
}
