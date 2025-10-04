using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CalculoReservaModel : PageModel
{
    [BindProperty] public int NumeroDias { get; set; }
    [BindProperty] public decimal PrecoDiaria { get; set; }
    public decimal ValorTotal { get; set; }

    public void OnPost()
    {
        Func<int, decimal, decimal> calcularTotal = (dias, preco) => dias * preco;
        ValorTotal = calcularTotal(NumeroDias, PrecoDiaria);
    }
}
