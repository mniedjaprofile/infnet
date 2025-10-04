using System.ComponentModel.DataAnnotations;

namespace EntidadeReserva.Models
{
    public class Destino
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O país é obrigatório")]
        [StringLength(50, ErrorMessage = "O país não pode exceder 50 caracteres")]
        [Display(Name = "País")]
        public string Pais { get; set; } = string.Empty;

        [Required(ErrorMessage = "A cidade é obrigatória")]
        [StringLength(50, ErrorMessage = "A cidade não pode exceder 50 caracteres")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O ponto turístico principal é obrigatório")]
        [StringLength(100, ErrorMessage = "O ponto turístico não pode exceder 100 caracteres")]
        [Display(Name = "Ponto Turístico Principal")]
        public string PontoTuristicoPrincipal { get; set; } = string.Empty;

        [Display(Name = "Descrição do Destino")]
        [StringLength(300, ErrorMessage = "A descrição não pode exceder 300 caracteres")]
        public string Descricao { get; set; } = string.Empty;
    }

    public class Hospedagem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O tipo de hospedagem é obrigatório")]
        [Display(Name = "Tipo de Hospedagem")]
        public string Tipo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O nome da hospedagem é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres")]
        [Display(Name = "Nome da Hospedagem")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Classificação (estrelas)")]
        [Range(1, 5, ErrorMessage = "A classificação deve ser entre 1 e 5 estrelas")]
        public int Classificacao { get; set; } = 3;

        [Display(Name = "Inclui café da manhã?")]
        public bool IncluiCafeManha { get; set; } = true;
    }

    public class PacoteTuristico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do pacote é obrigatório")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        [Display(Name = "Nome do Pacote")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(500, MinimumLength = 10,
            ErrorMessage = "A descrição deve ter entre 10 e 500 caracteres")]
        [Display(Name = "Descrição do Pacote")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, 100000, ErrorMessage = "O preço deve ser maior que zero")]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço por Pessoa")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A duração é obrigatória")]
        [Range(1, 30, ErrorMessage = "A duração deve ser entre 1 e 30 dias")]
        [Display(Name = "Duração")]
        public int Duracao { get; set; } = 7;

        [Required(ErrorMessage = "A categoria é obrigatória")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; } = string.Empty;

        [Display(Name = "Inclui passagem aérea?")]
        public bool IncluiPassagemAerea { get; set; } = true;

        [Display(Name = "Inclui traslados?")]
        public bool IncluiTraslados { get; set; } = true;

        [Display(Name = "Guia turístico incluído?")]
        public bool IncluiGuia { get; set; } = false;

        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        // PROPRIEDADE VALIDADE ADICIONADA
        [Required(ErrorMessage = "A data de validade é obrigatória")]
        [Display(Name = "Validade do Pacote")]
        [DataType(DataType.Date)]
        public DateTime Validade { get; set; } = DateTime.Today.AddMonths(6);

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; } = true;

        // OBJETOS COMPLEXOS
        public Destino Destino { get; set; } = new Destino();
        public Hospedagem Hospedagem { get; set; } = new Hospedagem();

        // Método para formatar o preço
        public string PrecoFormatado => Preco.ToString("C2");

        // Método para obter classificação em estrelas
        public string ClassificacaoEstrelas => new string('⭐', Hospedagem.Classificacao);

        // Método para verificar se o pacote está válido
        public bool EstaValido => Validade >= DateTime.Today && Ativo;

        // Método para obter dias até expirar
        public int DiasAteExpirar => (Validade - DateTime.Today).Days;
    }
}