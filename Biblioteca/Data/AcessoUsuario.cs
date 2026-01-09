using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class AcessoUsuarios
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
                            usuario.TipoUsuario = leitor["TipoUsuario"].ToString();

                            listaDeUsuarios.Add(usuario);
                        }
                    }
                }
            }

            return listaDeUsuarios;
        }
    }
}
