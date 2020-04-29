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
        public static float totalareceber = 0;

        public void AtualizaSaldo()
        {
            lbl_valortotal.Text = totalareceber.ToString("C");
            if (totalareceber < 0)
            {
                lbl_valortotal.ForeColor = Color.Red;
            }
            else if (totalareceber > 0)
            {
                lbl_valortotal.ForeColor = Color.Green;
            }
            else
            {
                lbl_valortotal.ForeColor = Color.Black;
            }
        }

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
            lbl_valortotal.Text = totalareceber.ToString("C");
            lbl_valortotal.ForeColor = Color.Black;
            txt_codigo.Focus();
        }

        private float ValorEntregas()
        {
            float devido = 0;
            try
            {
                Conexao conn = new Conexao();
                MySqlCommand consulta = new MySqlCommand(@"SELECT SUM(A.quantidade * A.valor_entrega) AS 'devido' FROM tb_itensentrada AS A INNER JOIN tb_entrada AS B ON A.cod_entrada = B.cod_entrada WHERE B.cod_prestador = @codigo GROUP BY B.cod_prestador", conn.Conectar());
                consulta.Parameters.AddWithValue("@codigo", codigo).MySqlDbType = MySqlDbType.Int32;
                MySqlDataReader dr = consulta.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        devido = float.Parse(dr["devido"].ToString());
                    }
                }
                conn.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao buscar valores devidos ao prestador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return devido;
        }

        private float ValorPagamentos()
        {
            float pago = 0;
            try
            {
                Conexao conn = new Conexao();
                MySqlCommand consulta = new MySqlCommand(@"SELECT SUM(valor) AS 'pago' FROM tb_pagprest WHERE cod_prestador = @codigo GROUP BY cod_prestador", conn.Conectar());
                consulta.Parameters.AddWithValue("@codigo", codigo).MySqlDbType = MySqlDbType.Int32;
                MySqlDataReader dr = consulta.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pago = float.Parse(dr["pago"].ToString());
                    }
                }
                conn.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao buscar valores pagos ao prestador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return pago;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            float devido = 0;
            float pago = 0;

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

                        conn.Desconectar();
                        devido = ValorEntregas();
                        pago = ValorPagamentos();
                        totalareceber = devido - pago;
                        AtualizaSaldo();
                    }
                    else
                    {
                        conn.Desconectar();
                        MessageBox.Show("Não foi encontrado prestador com esse código", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpaform();
                    }
                
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
                    try
                    {
                        Conexao conn = new Conexao();
                        MySqlCommand cmd = new MySqlCommand(@"DELETE FROM tb_prestadores WHERE codigo = @codigo", conn.Conectar());
                        cmd.Parameters.AddWithValue("@codigo", codigo).MySqlDbType = MySqlDbType.Int32;
                        cmd.ExecuteNonQuery();
                        conn.Desconectar();
                        limpaform();
                        MessageBox.Show("Registro de prestador apagado com sucesso.", "Registro apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        if (MessageBox.Show(erro.Message, "Erro ao apagar o registro do prestador", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        {
                            btn_excluir_Click(null, null);
                        }
                    }
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
                PagamentosPrestador pagamentos = new PagamentosPrestador();
                pagamentos.ShowDialog();
                AtualizaSaldo();
            }
        }
    }
}
