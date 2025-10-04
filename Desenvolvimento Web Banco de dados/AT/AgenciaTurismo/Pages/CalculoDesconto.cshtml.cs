using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Pages
{
    public class CalculoDescontoModel : PageModel
    {
        [BindProperty]
        public decimal PrecoOriginal { get; set; }

        public decimal PrecoComDesconto { get; set; }

        public void OnPost()
        {
            CalculateDelegate calc = new CalculateDelegate(DescontoService.AplicarDesconto10);
            PrecoComDesconto = calc(PrecoOriginal);
        }
    }
}
