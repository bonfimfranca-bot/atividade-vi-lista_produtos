using System.ComponentModel.DataAnnotations;

namespace MeuProjeto.Models
{
    public class ImcViewModel
    {
        [Required(ErrorMessage = "O peso é obrigatório.")]
        [Range(10, 300, ErrorMessage = "Digite um peso válido entre 10 e 300 kg.")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "A altura é obrigatória.")]
        [Range(0.5, 2.5, ErrorMessage = "Digite uma altura válida entre 0.5 e 2.5 metros.")]
        public double Altura { get; set; }

        public double? ResultadoImc { get; set; }
        public string Classificacao { get; set; }
    }
}