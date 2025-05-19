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

namespace WindowsFormsApp1
{
    public partial class F_LOGIN : Form
    {
        public F_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Nome.Text.Trim();
            string senha = Password.Text.Trim();

            if (Nome.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            try
            {
                conexao conexaoBD = new conexao();
                SqlConnection conn = conexaoBD.Abrir();

                string sql = "SELECT COUNT(*) FROM candidatos WHERE NomeCompleto = @nome AND Senha = @senha";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                int resultado = (int)cmd.ExecuteScalar();

                conexaoBD.Fechar();

                if (resultado > 0)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nome ou senha incorretos.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void F_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
