using Microsoft.AspNetCore.Mvc.RazorPages;
using EntidadeReserva.Models;
using EntidadeReserva.Services;

namespace EntidadeReserva.Pages
{
    public class PacotesListModel : PageModel
    {
        private readonly PacoteTuristicoService _pacoteService;

        public List<PacoteTuristico> Pacotes { get; set; } = new List<PacoteTuristico>();

        public PacotesListModel(PacoteTuristicoService pacoteService)
        {
            _pacoteService = pacoteService;
        }

        public void OnGet()
        {
            Pacotes = _pacoteService.ObterTodos();
        }
    }
}