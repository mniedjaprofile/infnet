using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }
    [Required, StringLength(100)]
    public string Nome { get; set; } = "";
    public string Email { get; set; } = "";
    public List<Reserva> Reservas { get; set; } = new();
}
