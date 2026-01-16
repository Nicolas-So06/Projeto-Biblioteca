using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class AcessoUsuario
    {
        public List<Usuario> ListarTodosUsuarios()
        {
            List<Usuario> listaDeUsuarios = new List<Usuario>();

            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT * FROM Usuarios";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    using (SqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.Id = Convert.ToInt32(leitor["Id"]);
                            usuario.Nome = leitor["Nome"].ToString();
                            usuario.CPF = leitor["CPF"].ToString();
                            usuario.Email = leitor["Email"].ToString();

                            if (leitor["Telefone"] != DBNull.Value)
                            {
                                usuario.Telefone = leitor["Telefone"].ToString();
                            }
                            else
                            {
                                usuario.Telefone = "";
                            }

                            usuario.TipoUsuario = leitor["TipoUsuario"].ToString();

                            listaDeUsuarios.Add(usuario);
                        }
                    }
                }
            }
            return listaDeUsuarios;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string sql = "INSERT INTO Usuarios (Nome, CPF, Email, Telefone, TipoUsuario) VALUES (@Nome, @CPF, @Email, @Telefone, @Tipo)";

                    using (SqlCommand comando = new SqlCommand(sql, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                        comando.Parameters.AddWithValue("@CPF", usuario.CPF);
                        comando.Parameters.AddWithValue("@Email", usuario.Email);
                        comando.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                        comando.Parameters.AddWithValue("@Tipo", usuario.TipoUsuario);

                        comando.ExecuteNonQuery();
                    }
                    transacao.Commit();
                }
                catch { transacao.Rollback(); throw; }

            }
        }

        public int VerificarSeUsuarioExiste(string cpf)
        {
            int idEncontrado = 0;

            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT Id FROM Usuarios WHERE Cpf = @Cpf";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Cpf", cpf);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idEncontrado = Convert.ToInt32(resultado);
                    }
                }
            }
            return idEncontrado;
        }

        public void EditarUsuario(Usuario usuario)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string sql = "UPDATE Usuarios SET Nome = @Nome, Email = @Email, Telefone = @Telefone, TipoUsuario = @Tipo, CPF = @CPF WHERE Id = @Id";

                    using (SqlCommand comando = new SqlCommand(sql, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@Id", usuario.Id);
                        comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                        comando.Parameters.AddWithValue("@Email", usuario.Email);
                        comando.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                        comando.Parameters.AddWithValue("@Tipo", usuario.TipoUsuario);
                        comando.Parameters.AddWithValue("@CPF", usuario.CPF);

                        comando.ExecuteNonQuery();
                    }
                    transacao.Commit();
                }
                catch { transacao.Rollback(); throw; }
            }
        }

        public void RemoverUsuario(int id)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();

                try 
                {
                    string sql = "DELETE FROM Usuarios WHERE Id = @Id";

                    using (SqlCommand comando = new SqlCommand(sql, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.ExecuteNonQuery();
                    }
                    transacao.Commit();
                }
                catch { transacao.Rollback(); throw; };
                
            }
        }
    }
}
