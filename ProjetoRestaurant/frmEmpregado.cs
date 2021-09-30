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

    }
}
