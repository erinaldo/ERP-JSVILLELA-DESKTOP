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
    public partial class EntregasPrestador : Form
    {
        public EntregasPrestador()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();

        private void CarregaItens()
        {
            DataView dv = new DataView(ds.Tables["Tabela de Itens"]);
            dv.RowFilter = "cod_entrada = " + dgv_entregas.SelectedRows[0].Cells[0].Value.ToString();
            dgv_itens.DataSource = dv;
            if (dgv_itens.ColumnCount > 0)
            {
                dgv_itens.Columns["cod_entrada"].Visible = false;
            }
        }

        private void EntregasPrestador_Load(object sender, EventArgs e)
        {
            lbl_nome.Text = "Nome: " + ConsultaPrestador.nomeprestador;
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT cod_entrada, dt_entrada AS 'Data', total AS 'Total (R$)' FROM tb_entrada WHERE cod_prestador = " + ConsultaPrestador.codigo.ToString() + " ORDER BY dt_entrada DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao.Conectar());
                da.Fill(ds, "Tabela de Entregas");
                conexao.Desconectar();
                dgv_entregas.DataSource = ds;
                dgv_entregas.DataMember = "Tabela de Entregas";
                dgv_entregas.Columns["cod_entrada"].Visible = false;
            }
            catch (Exception ERRO)
            {
                if (MessageBox.Show(ERRO.Message, "Erro ao carregar as entregas", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    EntregasPrestador_Load(null, null);
                }
            }
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT A.cod_entrada, B.descricao AS 'Descrição', A.quantidade AS 'Quantidade', A.valor_entrega AS 'Valor unitário (R$)', (A.valor_entrega * A.quantidade) AS 'Total do item (R$)' FROM tb_itensentrada AS A INNER JOIN tb_produtos AS B ON A.cod_produto = B.codigo INNER JOIN tb_entrada AS C ON A.cod_entrada = C.cod_entrada WHERE C.cod_prestador = " + ConsultaPrestador.codigo.ToString() + " ORDER BY dt_entrada DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao.Conectar());
                da.Fill(ds, "Tabela de Itens");
                conexao.Desconectar();
                CarregaItens();
            }
            catch (Exception ERRO)
            {
                if (MessageBox.Show(ERRO.Message, "Erro ao carregar os itens da entrega", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    EntregasPrestador_Load(null, null);
                }
            }
        }

        private void dgv_entregas_SelectionChanged(object sender, EventArgs e)
        {
            CarregaItens();
        }
    }
}
