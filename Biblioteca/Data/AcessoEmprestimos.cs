using Biblioteca.Models;
using System;
using System.Data.SqlClient;

namespace Biblioteca.Data
{
    public class AcessoEmprestimos
    {
        public void NovoEmprestimo(int idUsuario, int idLivro, DateTime dataDevolucao)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {

                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string sqlInsert = "INSERT INTO Emprestimos (UsuarioId, LivroId, DataEmprestimo, DataDevolucaoPrevista, StatusEmprestimo) VALUES (@UsuarioId, @LivroId, GETDATE(), @DataDevolucao, 'Ativo')";

                    using (SqlCommand comando = new SqlCommand(sqlInsert, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@UsuarioId", idUsuario);
                        comando.Parameters.AddWithValue("@LivroId", idLivro);
                        comando.Parameters.AddWithValue("@DataDevolucao", dataDevolucao);
                        comando.ExecuteNonQuery();
                    }

                    string sqlUpdate = "UPDATE Livros SET QuantidadeDisponivel = QuantidadeDisponivel - 1 WHERE Id = @IdLivro";

                    using (SqlCommand comando = new SqlCommand(sqlUpdate, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@IdLivro", idLivro);
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

        public bool TemEmprestimoPendente(int IdUsuario) 
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT COUNT(*) FROM Emprestimos WHERE UsuarioId = @Id AND StatusEmprestimo = 'Ativo'";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("Id", IdUsuario);

                    int quantidade = Convert.ToInt32(comando.ExecuteScalar());

                    return quantidade > 0;
                }
            }
        }

        public void ExcluirHistoricoDoUsuario (int IdUsuario)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "DELETE FROM Emprestimos WHERE UsuarioID = @Id";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("Id", IdUsuario);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public System.Data.DataTable ListarEmprestimosDetalhados()
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT e.Id, e.LivroId, u.Nome AS NomeUsuario, l.Titulo AS NomeLivro, e.DataEmprestimo, e.DataDevolucaoPrevista, e.StatusEmprestimo FROM Emprestimos e INNER JOIN Usuarios u ON e.UsuarioId = u.Id INNER JOIN Livros l ON e.LivroId = l.Id WHERE e.StatusEmprestimo = 'ATIVO'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    System.Data.DataTable tabela = new System.Data.DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }

        public void RealizarDevolucao(int idEmprestimo, int idLivro)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string sqlEmprestimo = "UPDATE Emprestimos SET StatusEmprestimo = 'Finalizado' WHERE Id = @id";
                    SqlCommand comandoEmprestimo = new SqlCommand(sqlEmprestimo, conexao, transacao);
                    comandoEmprestimo.Parameters.AddWithValue("@id", idEmprestimo);

                    comandoEmprestimo.ExecuteNonQuery();

                    string sqlEstoque = "UPDATE Livros SET QuantidadeDisponivel = QuantidadeDisponivel + 1 WHERE Id = @idLivro";
                    SqlCommand comandoLivro = new SqlCommand(sqlEstoque, conexao, transacao);
                    comandoLivro.Parameters.AddWithValue("@idLivro", idLivro);

                    comandoLivro.ExecuteNonQuery();

                    transacao.Commit();
                }
                catch (Exception)
                {
                    transacao.Rollback();
                    throw; 
                }
            }
        }

        public void AtualizarDataDevolucao(int idEmprestimo, DateTime novaData)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "UPDATE Emprestimos SET DataDevolucaoPrevista = @data WHERE Id = @id";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@data", novaData);
                    comando.Parameters.AddWithValue("@id", idEmprestimo);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public int VerificarEstoqueAtual(int idLivro)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT QuantidadeDisponivel FROM Livros WHERE Id = @id";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("Id", idLivro);


                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    return Convert.ToInt32(resultado);
                }

                return 0;
            }
        }
    }
}
