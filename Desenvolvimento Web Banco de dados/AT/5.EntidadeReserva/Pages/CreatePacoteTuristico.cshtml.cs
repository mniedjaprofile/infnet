using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EntidadeReserva.Pages
{
    public class PacoteTuristicoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do pacote � obrigat�rio")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O nome deve ter pelo menos 3 caracteres")]
        [Display(Name = "Nome do Pacote")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descri��o � obrigat�ria")]
        [StringLength(500, ErrorMessage = "A descri��o n�o pode exceder 500 caracteres")]
        [Display(Name = "Descri��o")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O destino � obrigat�rio")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O destino deve ter pelo menos 3 caracteres")]
        [Display(Name = "Destino")]
        public string Destino { get; set; } = string.Empty;

        [Required(ErrorMessage = "O pre�o � obrigat�rio")]
        [Range(0.01, 10000, ErrorMessage = "O pre�o deve ser maior que zero")]
        [Display(Name = "Pre�o")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Display(Name = "Dura��o (dias)")]
        [Range(1, 30, ErrorMessage = "A dura��o deve ser entre 1 e 30 dias")]
        public int DuracaoDias { get; set; } = 1;
    }

    public class CreatePacoteTuristicoModel : PageModel
    {
        [BindProperty]
        public PacoteTuristicoModel PacoteTuristico { get; set; } = new PacoteTuristicoModel();

        private static List<PacoteTuristicoModel> Pacotes = new List<PacoteTuristicoModel>();

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            PacoteTuristico.Id = Pacotes.Count + 1;
            Pacotes.Add(PacoteTuristico);

            TempData["SuccessMessage"] = $"Pacote Tur�stico '{PacoteTuristico.Nome}' cadastrado com sucesso!";
            return RedirectToPage("Index");
        }
    }
}