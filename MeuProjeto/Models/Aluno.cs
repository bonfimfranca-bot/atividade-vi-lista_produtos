using System;
using System.ComponentModel.DataAnnotations;

namespace MeuProjeto.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre {2} e {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório!")]
        [EmailAddress(ErrorMessage = "Digite um e-mail em formato válido (ex: seu@email.com).")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório!")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "O RA deve ter entre 5 e 10 caracteres.")]
        public string RA { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório!")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}