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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
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
            txbInfo12.Text = "Código Do Produto";
            txbInfo8.Text  = "Nome do Produto";
            txbInfo9.Text  = "Valor do Produto";
            txbInfo10.Text = "Quantidade";
            txbInfo11.Text = "Valor Total"; 
        }

        private void txbLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void carregarUsuario()
        {
            txbCodigoProduto.Text = dgvfunc.SelectedRows[0].Cells[0].Value.ToString();
            txbNomeProduto.Text = dgvfunc.SelectedRows[0].Cells[1].Value.ToString();
            txbValorProduto.Text = dgvfunc.SelectedRows[0].Cells[2].Value.ToString();
            txbQuantidade.Text = dgvfunc.SelectedRows[0].Cells[3].Value.ToString();
            txbValorTotal.Text = dgvfunc.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgvfunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarUsuario();
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
                    objComandoSql.CommandText = "Select *, valor_produto * quantidade_produto as valor_total from produto where nome_do_produto like ('%" + txbBuscar.Text + "%')";
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;

            if (txbNomeProduto.Text == "")
            {
                MessageBox.Show("Obrigatório campos Nome Empregado");
                txbNomeProduto.Focus();
            }
            else if (txbValorProduto.Text == "")
            {
                MessageBox.Show("Obrigatório campo Sexo");
                txbValorProduto.Focus();
            }
            else if (txbQuantidade.Text == "")
            {
                MessageBox.Show("Obrigatório campo Cargo");
                txbQuantidade.Focus();
            }
            else
            {
                try
                {
                    string nomeProduto = txbNomeProduto.Text;
                    string valorProduto = txbValorProduto.Text;
                    string quantidade = txbQuantidade.Text;

                    string strSql = $"insert into produto (nome_do_produto, valor_produto, quantidade_produto)" +
                        $" values ('{nomeProduto}','{valorProduto}','{quantidade}')";

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
                    MessageBox.Show("Produto Cadastrado com Sucesso!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            if (DialogResult.OK == MessageBox.Show("Tem certeza que deseja deletar?", "Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                MessageBox.Show("Resposta SIM");

                if (txbNomeProduto.Text == "")
                {
                    MessageBox.Show("Obrigatório campos Nome Empregado");
                    txbNomeProduto.Focus();
                }
                else if (txbValorProduto.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Sexo");
                    txbValorProduto.Focus();
                }
                else if (txbQuantidade.Text == "")
                {
                    MessageBox.Show("Obrigatório campo Cargo");
                    txbQuantidade.Focus();
                }
                else
                {
                    try
                    {
                        string nomeProduto = txbNomeProduto.Text;
                        string valorProduto = txbValorProduto.Text;
                        string quantidade = txbQuantidade.Text;
                        int cd = Convert.ToInt32(txbCodigoProduto.Text);

                        string strSql = $"DELETE FROM produto WHERE id_produto = @cd";

                        objComandoSql.CommandText = strSql;
                        objComandoSql.Connection = conn;

                        objComandoSql.Parameters.Add("@nome_do_produto", SqlDbType.VarChar).Value = nomeProduto;
                        objComandoSql.Parameters.Add("@valor_produto", SqlDbType.VarChar).Value = valorProduto;
                        objComandoSql.Parameters.Add("@quantidade_produto", SqlDbType.VarChar).Value = quantidade;
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

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            if (txbNomeProduto.Text == "")
            {
                MessageBox.Show("Obrigatório campos Nome Empregado");
                txbNomeProduto.Focus();
            }
            else if (txbValorProduto.Text == "")
            {
                MessageBox.Show("Obrigatório campo Sexo");
                txbValorProduto.Focus();
            }
            else if (txbQuantidade.Text == "")
            {
                MessageBox.Show("Obrigatório campo Cargo");
                txbQuantidade.Focus();
            }
            else
            {
                try
                {
                    string nomeProduto = txbNomeProduto.Text;
                    string valorProduto = txbValorProduto.Text;
                    string quantidade = txbQuantidade.Text;
                    int cd = Convert.ToInt32(txbCodigoProduto.Text);

                    string strSql = "update produto set nome_do_produto = @nomeProduto, valor_produto = @valorProduto, " +
                        "quantidade_produto = @quantidade where id_produto = @cd";

                    objComandoSql.CommandText = strSql;
                    objComandoSql.Connection = conn;

                    objComandoSql.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = nomeProduto;
                    objComandoSql.Parameters.Add("@valorProduto", SqlDbType.Float).Value = valorProduto;
                    objComandoSql.Parameters.Add("@quantidade", SqlDbType.Int).Value = quantidade;
                    objComandoSql.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    //conn.Open();
                    objComandoSql.ExecuteNonQuery();
                    objComandoSql.Parameters.Clear();

                    MessageBox.Show("Dados alterados com sucesso");
                    txbBuscar.Text = "*";
                    limparTextBoxes(this.Controls);
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

    }
}
