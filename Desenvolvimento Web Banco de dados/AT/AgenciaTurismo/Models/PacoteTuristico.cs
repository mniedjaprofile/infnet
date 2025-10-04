using System.ComponentModel.DataAnnotations;

public class PacoteTuristico
{
    public int Id { get; set; }

    [Required, StringLength(100, MinimumLength = 3)]
    public string Titulo { get; set; } = "";

    [Required, DataType(DataType.Date)]
    public DateTime DataInicio { get; set; } = DateTime.Today.AddDays(1);

    [Required, Range(1, 1000)]
    public int CapacidadeMaxima { get; set; } = 1;

    [Required, Range(0.01, 100000)]
    public decimal Preco { get; set; } = 0.01m;

    public List<Reserva> Reservas { get; set; } = new();
}
