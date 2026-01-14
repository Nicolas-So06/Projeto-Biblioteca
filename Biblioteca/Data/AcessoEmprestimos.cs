using Biblioteca.Models;
using System.Data.SqlClient;

namespace Biblioteca.Data
{
    public class AcessoEmprestimos
    {
        public void RegistrarEmprestimo(Emprestimo emprestimo)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            { 
                SqlTransaction transacao = conexao.BeginTransaction();

                try 
                {
                    string sqlInsert = "INSERT INTO Emprestimos(UsuarioId, LivroId, DataEmprestimo, DataDevolucaoPrevista, StatusEmprestimo) VALUES (@UsuarioId, @LivroId, @DataEmprestimo, @DataDevolucaoPrevista, @StatusEmprestimo)";

                    using(SqlCommand comando = new SqlCommand(sqlInsert, conexao))
                    {
                        comando.Parameters.AddWithValue("@UsuarioId", emprestimo.UsuarioId);
                        comando.Parameters.AddWithValue("@LivroId", emprestimo.LivroId);
                        comando.Parameters.AddWithValue("@DataEmprestimo", emprestimo.DataEmprestimo);
                        comando.Parameters.AddWithValue("DataDevolucaoPrevista", emprestimo.DataDevolucaoPrevista);
                        comando.Parameters.AddWithValue("StatusEmprestimo", emprestimo.StatusEmprestimo);
                        comando.ExecuteNonQuery();
                    }

                    string sqlUpdate = "UPDATE Livros SET QuantidadeDisponivel = QuantidadeDisponivel - 1 WHERE Id = @IdLivro";

                    using (SqlCommand comando = new SqlCommand(sqlUpdate, conexao))
                    {
                        comando.Parameters.AddWithValue("@IdLivro", emprestimo.LivroId);
                        comando.ExecuteNonQuery();
                    }

                    transacao.Commit();
                }
                catch
                {
                    transacao.Rollback();
                    throw;
                }
            }        
        }
    }
}
