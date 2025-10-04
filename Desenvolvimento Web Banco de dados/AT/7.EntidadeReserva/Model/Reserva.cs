using System.ComponentModel.DataAnnotations;

namespace EntidadeReserva.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        [Display(Name = "Nome do Cliente")]
        public string? NomeCliente { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A data da reserva é obrigatória")]
        [Display(Name = "Data da Reserva")]
        [DataType(DataType.Date)]
        public DateTime DataReserva { get; set; }

        [Display(Name = "Quantidade de Pessoas")]
        [Range(1, 10, ErrorMessage = "A quantidade deve ser entre 1 e 10 pessoas")]
        public int QuantidadePessoas { get; set; }

        [Display(Name = "Observações")]
        [StringLength(500, ErrorMessage = "As observações não podem exceder 500 caracteres")]
        public string? Observacoes { get; set; }
    }
}