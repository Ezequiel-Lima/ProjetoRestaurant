using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRestaurant
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEmpregado_Click(object sender, EventArgs e)
        {
            frmEmpregado empregado = new frmEmpregado();
            empregado.Show();
        }
    }
}
