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

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;
            if (txbBuscar.Text != "")
            {
                try
                {
                    objComandoSql.CommandText = "Select * from produto where nome_do_produto like ('%" + txbBuscar.Text + "%')";
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

    }
}
