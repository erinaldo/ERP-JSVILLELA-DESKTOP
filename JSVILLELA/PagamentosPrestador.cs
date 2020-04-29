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
using JSVILLELA.Relatórios;

namespace JSVILLELA
{
    public partial class PagamentosPrestador : Form
    {
        public PagamentosPrestador()
        {
            InitializeComponent();
        }

        private void CarregaPagamentos()
        {
            try
            {
                Conexao conexao = new Conexao();
                MySqlCommand consulta = new MySqlCommand(@"SELECT cod_pagamento, data_pag AS 'Data', valor AS 'Valor (R$)', forma AS 'Forma de pagamento' FROM tb_pagprest WHERE cod_prestador = @codigo ORDER BY data_pag DESC", conexao.Conectar());
                consulta.Parameters.AddWithValue("@codigo", ConsultaPrestador.codigo.ToString()).MySqlDbType = MySqlDbType.Int32;
                MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tabela de Entregas");
                conexao.Desconectar();
                dgv_pagamentos.DataSource = ds;
                dgv_pagamentos.DataMember = "Tabela de Entregas";
                dgv_pagamentos.Columns["cod_pagamento"].Visible = false;
            }
            catch (Exception ERRO)
            {
                if (MessageBox.Show(ERRO.Message, "Erro ao carregar os pagamentos.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    CarregaPagamentos();
                }
            }
        }

        private void PagamentosPrestador_Load(object sender, EventArgs e)
        {
            lbl_nome.Text = "Nome: " + ConsultaPrestador.nomeprestador;
            this.Width = 386;
            this.CenterToParent();
            dtp_pagamento.Format = DateTimePickerFormat.Custom;
            dtp_pagamento.CustomFormat = "dd/MM/yyyy";
            dtp_pagamento.MaxDate = System.DateTime.Today;
            
            CarregaPagamentos();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Width = 684;
            this.CenterToParent();
            dtp_pagamento.Value = System.DateTime.Today;
            txt_valor.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 386;
            this.CenterToParent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_forma.Text))
            {
                MessageBox.Show("Selecione a forma de pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_forma.Focus();
            }
            else if (string.IsNullOrEmpty(txt_valor.Text.Trim()))
            {
                MessageBox.Show("Informe o valor do pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valor.Focus();
            }
            else try
            {
                Conexao conn = new Conexao();
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO tb_pagprest(cod_prestador, data_pag, valor, forma) VALUES (@codigo, @data, @valor, @forma)", conn.Conectar());
                cmd.Parameters.AddWithValue("@codigo", ConsultaPrestador.codigo).MySqlDbType = MySqlDbType.Int32;
                cmd.Parameters.AddWithValue("@data", dtp_pagamento.Value).MySqlDbType = MySqlDbType.Date;
                cmd.Parameters.AddWithValue("@valor", txt_valor.Text.Trim()).MySqlDbType = MySqlDbType.Decimal;
                cmd.Parameters.AddWithValue("@forma", cb_forma.Text).MySqlDbType = MySqlDbType.VarChar;
                cmd.ExecuteNonQuery();
                conn.Desconectar();
                ConsultaPrestador.totalareceber -= float.Parse(txt_valor.Text.Trim());
                button2_Click(null,null);
                dgv_pagamentos.Focus();
                CarregaPagamentos();
            }
            catch(Exception erro)
            {
                if(MessageBox.Show(erro.Message, "Erro ao adicionar pagamento", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    btn_adicionar_Click(null,null);
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo apagar o registro de pagamento selecionado?", "Deletar pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Conexao conn = new Conexao();
                    MySqlCommand cmd = new MySqlCommand(@"DELETE FROM tb_pagprest WHERE cod_pagamento = @cod_pag", conn.Conectar());
                    cmd.Parameters.AddWithValue("@cod_pag", dgv_pagamentos.SelectedRows[0].Cells[0].Value.ToString()).MySqlDbType = MySqlDbType.Int32;
                    cmd.ExecuteNonQuery();
                    conn.Desconectar();
                    ConsultaPrestador.totalareceber += float.Parse(dgv_pagamentos.SelectedRows[0].Cells[2].Value.ToString());
                    CarregaPagamentos();
                }
                catch (Exception erro)
                {
                    if (MessageBox.Show(erro.Message, "Erro ao apagar o registro de pagamento", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        btn_excluir_Click(null, null);
                    }
                }
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            ReciboDePagamento recibo = new ReciboDePagamento(ConsultaPrestador.nomeprestador, dgv_pagamentos.SelectedRows[0].Cells[2].Value.ToString(), dgv_pagamentos.SelectedRows[0].Cells[1].Value.ToString());
            recibo.Show();
        }

        private void dgv_pagamentos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_pagamentos.SelectedRows.Count > 0)
            {
                if (dgv_pagamentos.SelectedRows[0].Cells[3].Value.ToString() == "Dinheiro")
                {
                    btn_imprimir.Visible = true;
                }
                else
                {
                    btn_imprimir.Visible = false;
                }
            }
        }
    }
}
