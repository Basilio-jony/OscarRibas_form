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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TEXTBOX_TEXTO_TextChanged(object sender, EventArgs e)
        {

        }

        private  void BTN_ENTRAR_Click(object sender, EventArgs e)
        {
            string senha = "123";
            string id = "1";

            if (TEXTBOX_ID.Text == id && textBox_SENHA.Text == senha)
            {
                MessageBox.Show("BEM-VINDO", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                F_cursos Formulario = new F_cursos();
                Formulario.Show(); // Mostra o novo formulário

                this.Hide(); // Esconde o formulário atual
            }
            else
            {
                MessageBox.Show("Dados incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
