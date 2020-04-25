using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSVILLELA.BLL;

namespace JSVILLELA
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (new BoLogin().ValidarLogin(txt_usuario.Text.Trim(), txt_senha.Text.Trim()))
                {
                    FormPrincipal frm_principal = new FormPrincipal();
                    this.Hide();
                    frm_principal.Show();
                }
                else
                {
                    MessageBox.Show("Login INVÁLIDO", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
