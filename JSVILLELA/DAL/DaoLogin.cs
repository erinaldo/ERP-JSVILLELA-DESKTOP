using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSVILLELA.DAL
{
    /// <summary>
    /// Classe DAL para Login
    /// </summary>
    class DaoLogin
    {
        #region Construtor
        public DaoLogin()
        {
            _conexao = new Conexao();
        }
        #endregion

        #region Atributos
        private Conexao _conexao;
        public static string usuario;
        private readonly string NOME_TABELA = "tb_login";
        #endregion

        #region Métodos
        public bool ValidarLogin(string pUsuario, string pSenha)
        {
            bool loginValido;

            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM " + NOME_TABELA + " WHERE USUARIO = @USUARIO AND SENHA = @SENHA;", _conexao.Conectar());
            cmd.Parameters.AddWithValue("@USUARIO", pUsuario).MySqlDbType = MySqlDbType.VarChar;
            cmd.Parameters.AddWithValue("@SENHA", pSenha).MySqlDbType = MySqlDbType.VarChar;

            MySqlDataReader dr = cmd.ExecuteReader();
            loginValido = dr.HasRows;

            if (loginValido)
            {
                while (dr.Read())
                {
                    usuario = dr["usuario"].ToString();
                }
            }

            dr.Close();
            _conexao.Desconectar();

            return loginValido;
        }
        #endregion
    }
}
