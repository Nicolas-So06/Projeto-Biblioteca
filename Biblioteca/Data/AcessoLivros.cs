using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using Biblioteca.Models;     

namespace Biblioteca.Data
{
    public class AcessoLivros
    {
        public List<Livro> ListarTodos()
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

        public void Cadastrar(Livro livro)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "INSERT INTO Livros (Titulo, Autor, AnoPublicacao, QuantidadeDisponivel, QuantidadeTotal) VALUES (@titulo, @autor, @ano, 1, 1)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@autor", livro.Autor);
                comando.Parameters.AddWithValue("@ano", livro.AnoPublicacao);

                comando.ExecuteNonQuery();
            }
        }
    }
}