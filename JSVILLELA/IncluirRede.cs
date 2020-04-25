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
    public partial class IncluirRede : Form
    {
        EntradaEstoque EntradaEst;
        public IncluirRede(EntradaEstoque Estoque)
        {
            InitializeComponent();
            EntradaEst = Estoque;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione o item a ser adicionado.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_quantidade.Text.Trim()))
            {
                MessageBox.Show("Insira a quantidade.", "Erro na quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantidade.Focus();
            }
            else
            {
                ListViewItem item = new ListViewItem("item", 0);
                item.SubItems.Add(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                item.SubItems.Add(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                item.SubItems.Add(txt_quantidade.Text);
                item.SubItems.Add(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                item.SubItems.Add(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                float valor = float.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) * float.Parse(txt_quantidade.Text);
                item.SubItems.Add(valor.ToString("N"));
                EntradaEst.lv_redes.Items.Add(item);
                EntradaEst.totalentrega += valor;
                this.Close();
            }
        }

        private void IncluirRede_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT codigo AS 'código', descricao AS 'Descrição', valor AS 'Valor (R$)', peso AS 'Peso (Kg)' FROM tb_produtos";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao.Conectar());
                
                da.Fill(ds, "Tabela de Produtos");
                conexao.Desconectar();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Tabela de Produtos";
            }
            catch(Exception ERRO)
            {
                if (MessageBox.Show(ERRO.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    IncluirRede_Load(null, null);
                }
            }
        }

        private DataSet ds = new DataSet();

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["Tabela de Produtos"]);
            dv.RowFilter = "Descrição Like '*" + txt_filtro.Text + "*'";
            dataGridView1.DataSource = dv;
        }
    }
}
