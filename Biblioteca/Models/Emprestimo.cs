using System;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int LivroId { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataDevolucaoPrevista { get; set; }

        public string StatusEmprestimo { get; set; }


    }
}
