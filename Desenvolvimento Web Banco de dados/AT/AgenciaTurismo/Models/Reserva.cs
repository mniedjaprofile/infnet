using System.ComponentModel.DataAnnotations;

public class Reserva
{
    public int Id { get; set; }

    [Required, StringLength(80, MinimumLength = 3)]
    public string NomeCliente { get; set; } = "";

    [Required]
    public DateTime DataReserva { get; set; }

    [Required]
    public int PacoteTuristicoId { get; set; }

    public PacoteTuristico? PacoteTuristico { get; set; }
}
