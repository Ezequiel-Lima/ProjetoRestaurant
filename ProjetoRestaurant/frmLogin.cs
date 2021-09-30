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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos de login e senha");
                txbLogin.Focus();
            }
            else
            {
                SqlConnection conn = Conexao.obterConexao(); //conn.Open();
                SqlCommand objComandoSql = new SqlCommand();

                objComandoSql.Connection = conn;
                objComandoSql.CommandText = "select * from conta where login_da_conta = ('" + txbLogin.Text + "') and senha = ('" + txbSenha.Text + "')";

                try
                {
                    SqlDataReader dt = objComandoSql.ExecuteReader();
                    
                    if (dt.HasRows)
                    {
                        //abrir o formulario
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Se não logar, fecha a conexão
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("" + erro);
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
