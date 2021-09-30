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
    public partial class frmEmpregado : Form
    {
        public frmEmpregado()
        {
            InitializeComponent();
        }

        private void limparTextBoxes(Control.ControlCollection controles)
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
            txbInfo.Text = "Empregado Nome";
            txbInfo2.Text = "Sexo";
            txbInfo3.Text = "Cargo";
            txbInfo4.Text = "Telefone";
            txbInfo5.Text = "Cidade";
            txbInfo6.Text = "Código";
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;
            if (txbBuscar.Text != "")
            {
                try
                {
                    objComandoSql.CommandText = "Select * from empregado where nome_empregado like ('%" + txbBuscar.Text + "%')";
                    objComandoSql.Connection = conn;


                    //recebe os dados de uma tabela apos a execuçã de uma select
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();


                    //recebe os dados da instrução select
                    da.SelectCommand = objComandoSql;
                    da.Fill(dt); //preenche o data table

                    dgvfunc.DataSource = dt;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("\n" + erro);
                    conn.Close();
                }
            }
        }

        private void txbLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;

            if (txbEmpregado.Text == "")
            {
                MessageBox.Show("Obrigatório campos Nome Empregado");
                txbEmpregado.Focus();
            }
            else if (txbSexo.Text == "")
            {
                MessageBox.Show("Obrigatório campo Sexo");
                txbSexo.Focus();
            }
            else if (txbCargo.Text == "")
            {
                MessageBox.Show("Obrigatório campo Cargo");
                txbCargo.Focus();
            }
            else if (txbTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório campo Telefone");
                txbTelefone.Focus();
            }
            else if (txbCidade.Text == "")
            {
                MessageBox.Show("Obrigatório campo Cidade");
                txbCidade.Focus();
            }
            else
            {
                try
                {
                    string nomeEmpregado = txbEmpregado.Text;
                    string sexo = txbSexo.Text;
                    string cargo = txbCargo.Text;
                    string telefone = txbTelefone.Text;
                    string cidade = txbCidade.Text;

                    string strSql = $"insert into empregado (nome_empregado, sexo, cargo, telefone, cidade, id_departamento)" +
                        $" values ('{nomeEmpregado}','{sexo}','{cargo}', '{telefone}', '{cidade}', 1)";

                    objComandoSql = new SqlCommand(strSql, conn);
                    objComandoSql.ExecuteNonQuery();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("" + erro);
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                    limparTextBoxes(this.Controls);
                    MessageBox.Show("Empregado Cadastrado com Sucesso!");
                }
            }
        }

        private void carregarUsuario()
        {
            txbCodigo.Text    = dgvfunc.SelectedRows[0].Cells[0].Value.ToString();
            txbEmpregado.Text = dgvfunc.SelectedRows[0].Cells[1].Value.ToString();
            txbSexo.Text      = dgvfunc.SelectedRows[0].Cells[2].Value.ToString();
            txbCargo.Text     = dgvfunc.SelectedRows[0].Cells[3].Value.ToString();
            txbTelefone.Text  = dgvfunc.SelectedRows[0].Cells[4].Value.ToString();
            txbCidade.Text    = dgvfunc.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void dgvfunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarUsuario();
        }

        private void dgvfunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            if (DialogResult.OK == MessageBox.Show("Tem certeza que deseja deletar?", "Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                MessageBox.Show("Resposta SIM");

                if (txbEmpregado.Text == "")
                {
                    MessageBox.Show("Obrigatório campos Nome Empregado");
                    txbEmpregado.Focus();
                }
                else if (txbSexo.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Sexo");
                    txbSexo.Focus();
                }
                else if (txbCargo.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Cargo");
                    txbCargo.Focus();
                }
                else if (txbTelefone.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Telefone");
                    txbTelefone.Focus();
                }
                else if (txbCidade.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Cidade");
                    txbCidade.Focus();
                }
                else if (txbCodigo.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Cidade");
                    txbCodigo.Focus();
                }
                else
                {
                    try
                    {
                        string nomeEmpregado = txbEmpregado.Text;
                        string sexo = txbSexo.Text;
                        string cargo = txbCargo.Text;
                        string telefone = txbTelefone.Text;
                        string cidade = txbCidade.Text;
                        int cd = Convert.ToInt32(txbCodigo.Text);

                        string strSql = $"DELETE FROM empregado WHERE id_empregado = @cd";

                        objComandoSql.CommandText = strSql;
                        objComandoSql.Connection = conn;

                        objComandoSql.Parameters.Add("@nome_empregado", SqlDbType.VarChar).Value = nomeEmpregado;
                        objComandoSql.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                        objComandoSql.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo;
                        objComandoSql.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                        objComandoSql.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
                        objComandoSql.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        objComandoSql.ExecuteNonQuery();
                        objComandoSql.Parameters.Clear();

                        MessageBox.Show("Dados deletados com sucesso");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Algo deu Ruim\n" + erro.Message);
                        conn.Close();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Respostas Não");
            }
            limparTextBoxes(this.Controls);
        }

    }
}
