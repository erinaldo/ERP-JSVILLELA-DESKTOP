using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JSVILLELA
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limparform();
        }

        private void Limparform()
        {
            txt_descricao.Clear();
            txt_peso.Clear();
            txt_venda.Clear();
            txt_local.Clear();
            txt_valor.Clear();
            txt_descricao.Focus();
        }

        private void CadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do formulário de cadastro?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_descricao.Text.Trim()))
            {
                MessageBox.Show("A descrição é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descricao.Focus();
            }
            else
            {
                try
                {
                    Conexao conn = new Conexao();
                    MySqlCommand cmd = new MySqlCommand(@"INSERT INTO tb_produtos(descricao, valor, venda, peso, local) VALUES (@descricao, @valor, @venda, @peso, @local)", conn.Conectar());
                    cmd.Parameters.AddWithValue("@descricao", txt_descricao.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@valor", txt_valor.Text.Trim()).MySqlDbType = MySqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@venda", txt_venda.Text.Trim()).MySqlDbType = MySqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@peso", txt_peso.Text.Trim()).MySqlDbType = MySqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@local", txt_local.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                    cmd.ExecuteNonQuery();
                    conn.Desconectar();

                    MessageBox.Show("Cadastro do produto realizado com sucesso.", "Confirmação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limparform();
                }
                catch (Exception ERRO)
                {
                    if (MessageBox.Show(ERRO.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        btn_cadastrar_Click(null, null);
                    }
                }
            }
        }
    }
}
