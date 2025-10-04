using AgenciaTurismo.Models;

public class CidadeDestino
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public int PaisDestinoId { get; set; }
    public PaisDestino? Pais { get; set; }
    public List<PacoteTuristico> Pacotes { get; set; } = new();
}
