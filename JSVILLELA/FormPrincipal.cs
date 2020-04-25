using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSVILLELA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AbrirForm(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void VerificaForm(Form formulario)
        {
            if (this.ActiveMdiChild == null)
            {
                AbrirForm(formulario);
            }
            else if (this.ActiveMdiChild.Name == formulario.Name)
            {
                MessageBox.Show("O formulário " + this.ActiveMdiChild.Text + " já está aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ActiveMdiChild.Close();
                if (this.ActiveMdiChild == null)
                {
                    AbrirForm(formulario);
                }
            }
        }

        private void prestadorDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroRedeiros cad_prestador = new CadastroRedeiros();
            VerificaForm(cad_prestador);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProdutos cad_produtos = new CadastroProdutos();
            VerificaForm(cad_produtos);
        }

        private void incluirEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaEstoque entrada = new EntradaEstoque();
            VerificaForm(entrada);
        }

        private void prestadoresDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPrestador consulta = new ConsultaPrestador();
            VerificaForm(consulta);
        }
    }
}
