using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EntidadeReserva.Pages
{
    public class PacoteTuristicoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do pacote é obrigatório")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O nome deve ter pelo menos 3 caracteres")]
        [Display(Name = "Nome do Pacote")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O destino é obrigatório")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O destino deve ter pelo menos 3 caracteres")]
        [Display(Name = "Destino")]
        public string Destino { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, 10000, ErrorMessage = "O preço deve ser maior que zero")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Display(Name = "Duração (dias)")]
        [Range(1, 30, ErrorMessage = "A duração deve ser entre 1 e 30 dias")]
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

            TempData["SuccessMessage"] = $"Pacote Turístico '{PacoteTuristico.Nome}' cadastrado com sucesso!";
            return RedirectToPage("Index");
        }
    }
}