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
using JSVILLELA.DAL;

namespace JSVILLELA
{
    public partial class EntradaEstoque : Form
    {
        public EntradaEstoque()
        {
            InitializeComponent();
            conn = new Conexao();
        }

        public float totalentrega = 0;

        private void EntradaEstoque_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = System.DateTime.Today;
            dateTimePicker.Value = System.DateTime.Today;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lv_redes.SelectedItems.Count != 0)
            {
                totalentrega -= float.Parse(lv_redes.SelectedItems[0].SubItems[6].Text);
                lv_redes.SelectedItems[0].Remove();
                lbl_totalentrega.Text = "Total da entrega: " + totalentrega.ToString("C");
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text.Trim()))
            {
                MessageBox.Show("Digite um código para a busca", "Código obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_codigo.Focus();
            }
            else try
            {
                MySqlCommand cmd = new MySqlCommand(@"SELECT nome FROM tb_prestadores WHERE codigo = @codigo", conn.Conectar());
                cmd.Parameters.AddWithValue("@codigo", txt_codigo.Text.Trim()).MySqlDbType = MySqlDbType.Int32;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txt_nome.Text = dr["nome"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi encontrado prestador com esse código.","Código não encontrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                conn.Desconectar();
            }
            catch(Exception ERRO)
            {
                if (MessageBox.Show(ERRO.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    pictureBox3_Click(null, null);
                }
            }
        }

        private Conexao conn;

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nome.Text))
            {
                txt_nome.Clear();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            picbox_menos.BackColor = Color.LightGray;
        }

        private void picbox_menos_MouseLeave(object sender, EventArgs e)
        {
            picbox_menos.BackColor = Color.Transparent;
        }

        private void picbox_mais_MouseEnter(object sender, EventArgs e)
        {
            picbox_mais.BackColor = Color.LightGray;
        }

        private void picbox_mais_MouseLeave(object sender, EventArgs e)
        {
            picbox_mais.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpaform();
        }

        private void limpaform()
        {
            txt_codigo.Clear();
            dateTimePicker.Value = System.DateTime.Today;
            lv_redes.Items.Clear();
            totalentrega = 0;
            lbl_totalentrega.Text = "Total da entrega: " + totalentrega.ToString("C");
            txt_codigo.Focus();
        }

        private void picbox_mais_Click(object sender, EventArgs e)
        {
            IncluirRede incluir = new IncluirRede(this);
            incluir.ShowDialog();
            lbl_totalentrega.Text = "Total da entrega: " + totalentrega.ToString("C");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Confirme se o código do prestador é válido clicando no botão de pesquisa.","Código não confirmado",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lv_redes.Items.Count == 0)
            {
                MessageBox.Show("A lista de itens está vazia.", "Lista vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(@"INSERT INTO tb_entrada (usuario_entrada,cod_prestador,total,dt_entrada) VALUES (@usuario_entrada,@cod_prestador,@total,@dt_entrada)", conn.Conectar());
                    cmd.Parameters.AddWithValue("@usuario_entrada", DaoLogin.usuario).MySqlDbType = MySqlDbType.VarChar;
                    cmd.Parameters.AddWithValue("@cod_prestador", txt_codigo.Text.Trim()).MySqlDbType = MySqlDbType.Int32;
                    cmd.Parameters.AddWithValue("@total", totalentrega).MySqlDbType = MySqlDbType.Decimal;
                    cmd.Parameters.AddWithValue("@dt_entrada", dateTimePicker.Value).MySqlDbType = MySqlDbType.DateTime;
                    cmd.ExecuteNonQuery();
                    conn.Desconectar();

                    cmd = new MySqlCommand("SELECT MAX(cod_entrada) FROM tb_entrada", conn.Conectar());
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    int codentrada = int.Parse(dr[0].ToString());
                    conn.Desconectar();

                    foreach (ListViewItem i in lv_redes.Items)
                    {
                        cmd = new MySqlCommand(@"INSERT INTO tb_itensentrada (cod_entrada,cod_produto,quantidade,valor_entrega) VALUES (@cod_entrada,@cod_produto,@quantidade,@valor_entrega)", conn.Conectar());
                        cmd.Parameters.AddWithValue("@cod_entrada", codentrada).MySqlDbType = MySqlDbType.Int32;
                        cmd.Parameters.AddWithValue("@cod_produto", i.SubItems[1].Text).MySqlDbType = MySqlDbType.Int32;
                        cmd.Parameters.AddWithValue("@quantidade", i.SubItems[3].Text).MySqlDbType = MySqlDbType.Int32;
                        cmd.Parameters.AddWithValue("@valor_entrega", i.SubItems[5].Text).MySqlDbType = MySqlDbType.Decimal;
                        cmd.ExecuteNonQuery();
                        conn.Desconectar();
                    }
                    
                    MessageBox.Show("Entrada incluida com sucesso!","Entrada incluida",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpaform();
                }
                catch (Exception ERRO)
                {
                    if (MessageBox.Show(ERRO.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        button2_Click(null, null);
                    }
                }
            }
        }

        private void EntradaEstoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do formulário de entrada de estoque?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
