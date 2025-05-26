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

           if(string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                conexao conexaoBD = new conexao();
                using (SqlConnection conn = conexaoBD.Abrir())
                {
                    string sql = "SELECT TOP 1 * FROM candidatos WHERE NomeCompleto = @nome AND Senha = @senha";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        SessaoUsuario.Id = (int)reader["Id"];
                        SessaoUsuario.NomeCompleto = reader["NomeCompleto"].ToString();
                        SessaoUsuario.NumeroBI = reader["NumeroBI"].ToString();
                        SessaoUsuario.Periodo = reader["Periodo"].ToString();
                        SessaoUsuario.Senha = reader["Senha"].ToString();

                        MessageBox.Show("Login Realizado com sucesso");

                        //esta e a parte para chamar o formulario de dashboard ou perfil
                       /* F_Perfil telaPerfil = new F_Perfil(); 
                        telaPerfil.Show();
                        this.Hide();*/
                    }
                    else
                    {
                        MessageBox.Show("Nome ou senha incorretos.");
                    }
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
