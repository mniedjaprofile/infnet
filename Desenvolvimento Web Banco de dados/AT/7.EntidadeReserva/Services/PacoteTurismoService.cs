using EntidadeReserva.Models;

namespace EntidadeReserva.Services
{
    public class PacoteTuristicoService
    {
        private readonly List<PacoteTuristico> _pacotes = new()
        {
            new PacoteTuristico
            {
                Id = 1,
                Nome = "Pacote Romântico Paris",
                Descricao = "Uma experiência inesquecível na cidade do amor...",
                Destino = "Paris, França",
                Preco = 8999.99m,
                Duracao = 7,
                Categoria = "Romântico",
                Validade = new DateTime(2024, 12, 31), // VALIDADE ADICIONADA
                DataCriacao = new DateTime(2024, 1, 15),
                Ativo = true
            },
            new PacoteTuristico
            {
                Id = 2,
                Nome = "Aventura nas Cataratas",
                Descricao = "Para os amantes da natureza e aventura...",
                Destino = "Foz do Iguaçu, Brasil",
                Preco = 1599.50m,
                Duracao = 4,
                Categoria = "Aventura",
                Validade = new DateTime(2024, 10, 15), // VALIDADE ADICIONADA
                DataCriacao = new DateTime(2024, 1, 20),
                Ativo = true
            },
            new PacoteTuristico
            {
                Id = 3,
                Nome = "Cultural no Rio de Janeiro",
                Descricao = "Conheça as maravilhas do Rio...",
                Destino = "Rio de Janeiro, Brasil",
                Preco = 2299.00m,
                Duracao = 5,
                Categoria = "Cultural",
                Validade = new DateTime(2024, 11, 30), // VALIDADE ADICIONADA
                DataCriacao = new DateTime(2024, 2, 1),
                Ativo = true
            }
        };

        public List<PacoteTuristico> ObterTodos() => _pacotes;

        public PacoteTuristico? ObterPorId(int id)
        {
            return _pacotes.FirstOrDefault(p => p.Id == id);
        }

        public List<PacoteTuristico> ObterAtivos()
            => _pacotes.Where(p => p.Ativo && p.Validade >= DateTime.Today).ToList();

        public void Adicionar(PacoteTuristico pacote)
        {
            pacote.Id = _pacotes.Count > 0 ? _pacotes.Max(p => p.Id) + 1 : 1;
            pacote.DataCriacao = DateTime.Now;
            _pacotes.Add(pacote);
        }
    }
}