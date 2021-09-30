using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRestaurant
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void limparCampos(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao(); //conn.Open();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;

            if (txbNome.Text == "")
            {
                MessageBox.Show("Obrigatório campo Nome");
                txbNome.Focus();
            }
            else if (txbEmail.Text == "")
            {
                MessageBox.Show("Obrigatório campo Email");
                txbEmail.Focus();
            }
            else if (txbLogin.Text == "")
            {
                MessageBox.Show("Obrigatório campo Login");
                txbLogin.Focus();
            }
            else if (txbSenha.Text == "")
            {
                MessageBox.Show("Obrigatório campo Senha");
                txbSenha.Focus();
            }
            else if (txbConfirmarSenha.Text == "")
            {
                MessageBox.Show("Obrigatório campo Confirmar Senha");
                txbConfirmarSenha.Focus();
            }
            else if(txbSenha.Text != txbConfirmarSenha.Text)
            {
                MessageBox.Show("Senha está diferente no Confirmar Senha");
                txbConfirmarSenha.Focus();
            }
            else
            {
                try
                {
                    string nome = txbNome.Text;
                    string email = txbEmail.Text;
                    string login = txbLogin.Text;
                    string senha = txbSenha.Text;
                    string cod = txbCodigoConta.Text;

                    string strSql = $"insert into conta (id_login, login_da_conta, senha) values ('{cod}','{login}','{senha}')";
                    string strSql2 = $"insert into administrador (nome_administrador, email, id_login) values ('{nome}','{email}','{cod}')";

                    objComandoSql = new SqlCommand(strSql, conn);
                    objComandoSql.ExecuteNonQuery();

                    objComandoSql = new SqlCommand(strSql2, conn);
                    objComandoSql.ExecuteNonQuery();

                    limparCampos(this.Controls);
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Código da conta ja existente");
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
