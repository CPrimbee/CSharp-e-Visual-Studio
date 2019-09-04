using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class FormMatriculaDeAluno : Form
    {
        public FormMatriculaDeAluno()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if(txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE "+
                    "NASCIMENTO com 4 digítos", "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }
    }
}
