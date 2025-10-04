using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EntidadeReserva.Pages
{
    // Modelo da Reserva definido DENTRO do mesmo arquivo
    public class ReservaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente � obrigat�rio")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail � obrigat�rio")]
        [EmailAddress(ErrorMessage = "Informe um e-mail v�lido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data da reserva � obrigat�ria")]
        [Display(Name = "Data da Reserva")]
        [DataType(DataType.Date)]
        public DateTime DataReserva { get; set; } = DateTime.Today;

        [Display(Name = "Quantidade de Pessoas")]
        [Range(1, 10, ErrorMessage = "A quantidade deve ser entre 1 e 10 pessoas")]
        public int QuantidadePessoas { get; set; } = 1;

        [Display(Name = "Observa��es")]
        [StringLength(500, ErrorMessage = "As observa��es n�o podem exceder 500 caracteres")]
        public string Observacoes { get; set; } = string.Empty;
    }

    public class CreateReservaModel : PageModel
    {
        [BindProperty]
        public ReservaModel Reserva { get; set; } = new ReservaModel();

        private static List<ReservaModel> Reservas = new List<ReservaModel>();

        public void OnGet()
        {
            // J� inicializado com valores padr�o
        }

        public IActionResult OnPost()
        {
            // Valida��o usando ModelState.IsValid
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Reserva.Id = Reservas.Count + 1;
            Reservas.Add(Reserva);

            TempData["SuccessMessage"] = $"Reserva #{Reserva.Id} cadastrada com sucesso!";
            return RedirectToPage("/Index");
        }
    }
}