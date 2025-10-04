using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EntidadeReserva.Models;
using System.ComponentModel.DataAnnotations;

namespace EntidadeReserva.Pages
{
    public class CreatePacoteTuristicoModel : PageModel
    {
        [BindProperty]
        public PacoteTuristico PacoteTuristico { get; set; } = new PacoteTuristico();

    
        public List<string> Categorias { get; set; } = new List<string>
        {
            "Aventura", "Cultural", "Relaxamento", "Romântico", "Família", "Luxo"
        };

        public List<string> TiposHospedagem { get; set; } = new List<string>
        {
            "Hotel", "Pousada", "Resort", "Chalé", "Apartamento", "Hostel"
        };

        private static List<PacoteTuristico> Pacotes = new List<PacoteTuristico>();

        public void OnGet()
        {
            PacoteTuristico.Validade = DateTime.Today.AddMonths(6);
        }

        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                
                foreach (var error in ModelState)
                {
                    if (error.Value.Errors.Count > 0)
                    {
                        Console.WriteLine($"Erro em {error.Key}: {error.Value.Errors[0].ErrorMessage}");
                    }
                }
                return Page();
            }

            PacoteTuristico.Id = Pacotes.Count + 1;
            Pacotes.Add(PacoteTuristico);

            TempData["SuccessMessage"] =
                $"Pacote '{PacoteTuristico.Nome}' cadastrado com sucesso! " +
                $"Destino: {PacoteTuristico.Destino.Cidade} - {PacoteTuristico.Destino.Pais}";

            return RedirectToPage("Index");
        }
    }
}