using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace JSVILLELA
{
    class Conexao
    {
        public Conexao()
        {
            string stringDeConexao = "server=" + this.server + ";User Id=" + this.userID + ";database=" + this.nomeBD + ";pwd=" + this.password;
            this.conn = new MySqlConnection(stringDeConexao);
        }

        private readonly string server = "108.179.252.200";

        private readonly string userID = "sitioc93_villela";

        private readonly string nomeBD = "sitioc93_db_jsvillela";

        private readonly string password = "jsvillela@2020#";

        private MySqlConnection conn;

        public MySqlConnection Conectar()
        {
            try
            {
                if (this.conn.State != ConnectionState.Open)
                    this.conn.Open();

                return this.conn;
            }
            catch
            {
                return null;
            }
        }

        public MySqlConnection Desconectar()
        {
            try
            {
                if (this.conn.State != ConnectionState.Closed)
                    this.conn.Close();

                return this.conn;
            }
            catch
            {
                return null;
            }
        }

    }
}
