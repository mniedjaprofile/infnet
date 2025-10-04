namespace AgenciaTurismo.Models
{
    public static class DescontoService
    {
        public static decimal AplicarDesconto10(decimal preco)
            => Math.Round(preco * 0.90m, 2);
    }
}
