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
           // carregarDados();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                string nome = textBox1.Text.Trim();
                string bi = textBox2.Text.Trim();
                string periodo = comboBox1.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(bi) || string.IsNullOrWhiteSpace(periodo))
                {
                    MessageBox.Show("preencha todos os campos");
                    return;
                }
                //gerar senha com base no nome
                string senha = senhaHelper.GerarSenha(nome);

                Candidato candidato = new Candidato
                {
                    NomeCompleto = nome,
                    NumeroBI = bi,
                    Periodo = periodo,
                    Senha = senha
                };
                //salvar no banco de dados
                conexao c = new conexao();
                using(SqlConnection conn = c.Abrir())
                {
                    CandidatoRepo repo = new CandidatoRepo(conn);
                    repo.adicionar(candidato);
                }
                MessageBox.Show("cadastro realizado com sucesso a senha é: " + senha);
                
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

        /* private void carregarDados()
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
         }*/

        public class Candidato
        {
            public string NomeCompleto { get; set; }
            public string NumeroBI { get; set; }
            public string Periodo { get; set; }
            public string Senha { get; set; }
        }

        public class CandidatoRepo
        {
            private readonly SqlConnection _connection;

            public CandidatoRepo(SqlConnection connection)
            {
                _connection = connection;
            }

            public void adicionar(Candidato candidato)
            {
                string sql = "INSERT INTO candidatos (NomeCompleto, NumeroBI, Periodo, Senha)" + "Values (@nome, @bi, @periodo, @senha)";

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@nome", candidato.NomeCompleto);
                    cmd.Parameters.AddWithValue("@bi", candidato.NumeroBI);
                    cmd.Parameters.AddWithValue("@periodo", candidato.Periodo);
                    cmd.Parameters.AddWithValue("@senha", candidato.Senha);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public static class senhaHelper
        {
            public static string GerarSenha(string nome)
            {
                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new ArgumentException("O nome nao pode estar vazio.");
                }

                string[] partes = nome.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                string primeiraLetra = partes[0][0].ToString().ToLower();
                string ultimaLetra = partes[partes.Length - 1][0].ToString().ToLower(); // ^1 significa o último elemento

                return "123456789" + primeiraLetra + ultimaLetra;
            }
        }


    }
}
