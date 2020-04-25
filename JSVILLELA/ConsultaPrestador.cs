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
    public partial class ConsultaPrestador : Form
    {
        public ConsultaPrestador()
        {
            InitializeComponent();
        }

        public static int codigo = 0;
        public static string nomeprestador = null;
        private float totalareceber = 0;

        private void ConsultaPrestador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do formulário de consulta?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void limpaform()
        {
            codigo = 0;
            nomeprestador = null;
            totalareceber = 0;
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_cep.Clear();
            txt_uf.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_complemento.Clear();
            txt_banco.Clear();
            txt_tipoconta.Clear();
            txt_agencia.Clear();
            txt_conta.Clear();
            lbl_total.Text = "Total a receber: " + totalareceber.ToString("C");
            txt_codigo.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text.Trim()))
            {
                MessageBox.Show("Digite um código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_codigo.Focus();
            }
            else try
            {
                Conexao conn = new Conexao();
                MySqlCommand consulta = new MySqlCommand(@"SELECT * FROM tb_prestadores WHERE codigo = @codigo", conn.Conectar());
                consulta.Parameters.AddWithValue("@codigo", txt_codigo.Text.Trim()).MySqlDbType = MySqlDbType.Int32;
                MySqlDataReader dr = consulta.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        codigo = int.Parse(dr["codigo"].ToString());
                        nomeprestador = dr["nome"].ToString();
                        txt_nome.Text = dr["nome"].ToString();
                        txt_cpf.Text = dr["cpf"].ToString();
                        txt_telefone.Text = dr["telefone"].ToString();
                        txt_celular.Text = dr["celular"].ToString();
                        txt_cep.Text = dr["cep"].ToString();
                        txt_uf.Text = dr["uf"].ToString();
                        txt_cidade.Text = dr["cidade"].ToString();
                        txt_endereco.Text = dr["endereco"].ToString();
                        txt_numero.Text = dr["numero"].ToString();
                        txt_bairro.Text = dr["bairro"].ToString();
                        txt_complemento.Text = dr["complemento"].ToString();
                        txt_banco.Text = dr["banco"].ToString();
                        txt_tipoconta.Text = dr["tipoconta"].ToString();
                        txt_agencia.Text = dr["agencia"].ToString();
                        txt_conta.Text = dr["conta"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi encontrado prestador com esse código", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaform();
                }
                conn.Desconectar();
            }
            catch (Exception erro)
            {
                if (MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    btn_buscar_Click(null, null);
                }
            }
        }

        private bool VerificaCodigo()
        {
            if(codigo == 0)
            {
                MessageBox.Show("Nenhum prestador selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_codigo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (VerificaCodigo())
            {
                if (totalareceber != 0)
                {
                    MessageBox.Show("Você não pode apagar um prestador que possui valores pendentes ou a receber.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Você tem certeza que quer apagar o registro de " +nomeprestador +"? Essa ação não pode ser desfeita", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                }
            }
        }

        private void btn_entregas_Click(object sender, EventArgs e)
        {
            if (VerificaCodigo())
            {
                EntregasPrestador entregas = new EntregasPrestador();
                entregas.ShowDialog();
            }
        }

        private void btn_pagamentos_Click(object sender, EventArgs e)
        {
            if (VerificaCodigo())
            {

            }
        }

        private void ConsultaPrestador_Load(object sender, EventArgs e)
        {
            lbl_total.Text = "Total a receber: " + totalareceber.ToString("C");
        }
    }
}
