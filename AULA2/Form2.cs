using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULA2
{
    public partial class F_cursos : Form
    {
        public F_cursos()
        {
            InitializeComponent();
        }

        private void BNT_SAIR2_Click(object sender, EventArgs e)
        {
            this.Close();

            // MessageBox.Show("Ques sair", "saida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("QUES REALMENTE SAIR", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            
            
        }

    }
}
