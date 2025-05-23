using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;

namespace WindowsFormsApp1
{
    public partial class F_CADASTRO : Form
    {
        public F_CADASTRO()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_CADASTRO_Load(object sender, EventArgs e)
        {
            carregarDados();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                string nome = textBox1.Text.Trim();
                string bi = textBox2.Text.Trim();
                string periodo = comboBox1.SelectedItem.ToString();

                //criar a senha
                string letras = "";
                if (!string.IsNullOrEmpty(nome))
                {
                    string[] partes = nome.Split(' ');
                    if (partes.Length >= 2) {
                        letras = partes[0][0].ToString().ToLower() + partes[1][0].ToString().ToLower();
                    }
                    else
                    {
                        letras = partes[0].Substring(0, Math.Min(2, partes[0].Length)).ToLower();
                    }
                    string senha = "123456789" + letras; //ate aqui cria a senha

                    conexao c = new conexao();
                    SqlConnection conn = c.Abrir();

                    string sql = "Insert INTO candidatos (NomeCompleto, NumeroBI, Periodo, Senha) Values (@nome, @bi, @periodo, @senha)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@bi", bi);
                    cmd.Parameters.AddWithValue("@periodo", periodo);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.ExecuteNonQuery();
                    c.Fechar();

                    MessageBox.Show("Cadastro realizado com sucesso! Sua senha é: " + senha);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                F_LOGIN login = new F_LOGIN();
                
                login.Show();
                this.Hide();
                       
        }

        private void carregarDados()
        {
            try
            {
                conexao c = new conexao();
                using (SqlConnection conn = c.Abrir())
                {
                    string sql = "SELECT * FROM datas_exames";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}
