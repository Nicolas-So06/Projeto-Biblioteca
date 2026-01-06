using System.Data.SqlClient; 
using System.Configuration;  

namespace Biblioteca.Data
{
    public class Conexao
    {
        public static SqlConnection ObterConexao()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoBiblioteca"].ConnectionString;

            SqlConnection conexao = new SqlConnection(stringConexao);

            conexao.Open();

            return conexao;
        }
    }
}