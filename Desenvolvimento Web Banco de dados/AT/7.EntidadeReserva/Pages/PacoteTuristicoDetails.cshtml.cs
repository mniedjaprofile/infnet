using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EntidadeReserva.Models;
using EntidadeReserva.Services;

namespace EntidadeReserva.Pages
{
    public class PacoteTuristicoDetailsModel : PageModel
    {
        private readonly PacoteTuristicoService _pacoteService;

        public PacoteTuristico? Pacote { get; set; }

        // PROPRIEDADE ENCONTRADO
        public bool Encontrado => Pacote != null;

        public PacoteTuristicoDetailsModel(PacoteTuristicoService pacoteService)
        {
            _pacoteService = pacoteService;
        }

        // ROTA: /PacoteTuristicoDetails/123
        public IActionResult OnGet(int id)
        {
            // Busca o pacote pelo ID recebido na rota
            Pacote = _pacoteService.ObterPorId(id);

            if (Pacote == null)
            {
                TempData["ErrorMessage"] = $"Pacote turístico com ID {id} não encontrado.";
                return RedirectToPage("PacotesList");
            }

            return Page();
        }
    }
}