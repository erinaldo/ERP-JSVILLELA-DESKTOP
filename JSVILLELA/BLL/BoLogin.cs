using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSVILLELA.DAL;

namespace JSVILLELA.BLL
{
    /// <summary>
    /// Classe BLL para Login
    /// </summary>
    public class BoLogin
    {
        #region Métodos
        public bool ValidarLogin(string pUsuario, string pSenha)
        {
            return new DaoLogin().ValidarLogin(pUsuario, pSenha);
        }
        #endregion
    }
}
