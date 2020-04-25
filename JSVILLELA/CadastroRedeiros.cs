using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSVILLELA
{
    public partial class CadastroRedeiros : Form
    {
        public CadastroRedeiros()
        {
            InitializeComponent();
            conn = new Conexao();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text.Trim())) {
                MessageBox.Show("O nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
            }
            else if (txt_nome.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite um nome válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
            }
            else
            {
                try
                {
                    codigo = null;
                    Consultacodigo();

                    if (string.IsNullOrEmpty(codigo))
                    {
                        MySqlCommand cmd = new MySqlCommand(@"INSERT INTO tb_prestadores(nome,cpf,telefone,celular,cep,uf,cidade,endereco,numero,bairro,complemento,banco,tipoconta,agencia,conta) VALUES (@nome,@cpf,@telefone,@celular,@cep,@uf,@cidade,@endereco,@numero,@bairro,@complemento,@banco,@tipoconta,@agencia,@conta)", conn.Conectar());
                        cmd.Parameters.AddWithValue("@nome", txt_nome.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@cpf", mtxt_cpf.Text).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@telefone", mtxt_telefone.Text).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@celular", mtxt_celular.Text).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@cep", mtxt_cep.Text).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@uf", cbox_uf.Text).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@numero", txt_numero.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@complemento", txt_complemento.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@banco", txt_banco.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@tipoconta", cbox_tipoconta.Text).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@agencia", txt_agencia.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@conta", txt_conta.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
                        cmd.ExecuteNonQuery();
                        conn.Desconectar();

                        Consultacodigo();

                        MessageBox.Show("Cadastro realizado com sucesso. Código do Prestador: " + codigo, "Confirmação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limparform();
                    }
                    else
                    {
                        MessageBox.Show("Já existe um cadastro no banco de dados com esse nome. Código do prestador: " + codigo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ERRO)
                {
                    if(MessageBox.Show(ERRO.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        btn_cadastrar_Click(null,null);
                    }
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limparform();
        }

        private void Limparform (){
            txt_nome.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_complemento.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_agencia.Clear();
            txt_banco.Clear();
            txt_conta.Clear();
            mtxt_celular.Clear();
            mtxt_cep.Clear();
            mtxt_cpf.Clear();
            mtxt_telefone.Clear();
            txt_nome.Focus();
        }

        private void Consultacodigo()
        {
            MySqlCommand consulta = new MySqlCommand(@"SELECT codigo FROM tb_prestadores WHERE nome = @nome", conn.Conectar());
            consulta.Parameters.AddWithValue("@nome", txt_nome.Text.Trim()).MySqlDbType = MySqlDbType.VarChar;
            dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                codigo = dr["codigo"].ToString();
            }
            conn.Desconectar();
        }

        private MySqlDataReader dr;
        private Conexao conn;
        private string codigo;

        private void CadastroRedeiros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja sair do formulário de cadastro?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XmlCep xmlcep = new XmlCep();

            try
            {
                xmlcep.Buscacep(mtxt_cep.Text);
            }
            catch (Exception ERRO)
            {
                if (MessageBox.Show(ERRO.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    pictureBox1_Click(null, null);
                }
            }
            
            txt_cidade.Text = xmlcep.Cidade;
            txt_bairro.Text = xmlcep.Bairro;
            txt_endereco.Text = xmlcep.Endereco;
            txt_complemento.Text = xmlcep.Complemento;
            cbox_uf.Text = xmlcep.Uf;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CpfCnpj cpf = new CpfCnpj();
            if (CpfCnpj.CpfCnpjUtils.IsValid(mtxt_cpf.Text.Replace(".", "").Replace("-", "").Trim()))
            {
                MessageBox.Show("CPF válido.","Validação de CPF",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CPF inválido.", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
