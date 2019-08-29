using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtPrimerioValor.Text;
            txtPrimerioValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = auxiliar;

            MessageBox.Show("Troca de valores concluída",
                "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
