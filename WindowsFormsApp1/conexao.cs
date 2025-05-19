using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    internal class conexao
    {
        private SqlConnection conn;

        public conexao()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SistemaExamesConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }
            
        public SqlConnection Abrir(){
                if(conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn;
            }
        public void Fechar()
            {
                if(conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        
    }
}
