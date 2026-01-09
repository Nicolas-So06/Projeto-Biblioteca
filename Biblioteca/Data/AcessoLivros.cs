using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using Biblioteca.Models;     

namespace Biblioteca.Data
{
    public class AcessoLivros
    {
        public List<Livro> ListarTodosLivros()
        {
            List<Livro> listaDeLivros = new List<Livro>();

            using (SqlConnection conexao = Conexao.ObterConexao())
            {

                string sql = "SELECT * FROM Livros";
                SqlCommand comando = new SqlCommand(sql, conexao);

                using (SqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Livro livro = new Livro();

                        livro.Id = Convert.ToInt32(leitor["Id"]);
                        livro.Titulo = leitor["Titulo"].ToString();
                        livro.Autor = leitor["Autor"].ToString();
                        livro.AnoPublicacao = Convert.ToInt32(leitor["AnoPublicacao"]);
                        livro.QuantidadeTotal = Convert.ToInt32(leitor["QuantidadeTotal"]);
                        livro.QuantidadeDisponivel = Convert.ToInt32(leitor["QuantidadeDisponivel"]);

                        listaDeLivros.Add(livro);
                    }
                }
            }

            return listaDeLivros;
        }


        public void CadastrarLivro(Livro livro, int quantidadeInicial)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "INSERT INTO Livros (Titulo, Autor, AnoPublicacao, QuantidadeDisponivel, QuantidadeTotal) VALUES (@titulo, @autor, @ano, @Qtd, @Qtd)";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                    comando.Parameters.AddWithValue("@autor", livro.Autor);
                    comando.Parameters.AddWithValue("@ano", livro.AnoPublicacao);
                    comando.Parameters.AddWithValue("@Qtd", quantidadeInicial);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void RemoverLivro(int idLivro)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "DELETE FROM Livros WHERE Id = @Id";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", idLivro);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EditarLivro(Livro livro)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "UPDATE Livros SET Titulo = @Titulo, Autor = @Autor, AnoPublicacao = @Ano WHERE Id = @Id";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                    comando.Parameters.AddWithValue("@Autor", livro.Autor);
                    comando.Parameters.AddWithValue("@Ano", livro.AnoPublicacao);

                    comando.Parameters.AddWithValue("@Id", livro.Id);

                    comando.ExecuteNonQuery(); 
                }
            }
        }

        public int VerificarSeLivroExiste(string titulo)
        {
            int idEncontrado = 0;

            using (SqlConnection conexao = Conexao.ObterConexao())
            {

                string sql = "SELECT Id FROM Livros WHERE Titulo = @Titulo";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Titulo", titulo);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idEncontrado = Convert.ToInt32(resultado);
                    }
                }
            } 
            return idEncontrado;
        }

        public void AdicionarQuantidadeLivro(int id, int quantidade)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "UPDATE Livros SET QuantidadeTotal = QuantidadeTotal + @Qtd, QuantidadeDisponivel = QuantidadeDisponivel + @Qtd WHERE Id = @Id";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Qtd", quantidade);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}