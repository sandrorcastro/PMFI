namespace Domain.Entities
{
    public class Economia
    {
        public long ImovelId { get; set; }
        public long EconomiaId { get; set; }
        public Imovel Imovel { get; set; }
        // public ICollection<Economia_Pessoa> Pessoas { get; set; }
        public ICollection<Economia_Entidade> Pessoas { get; set; }

        public ICollection<Endereco_Entidade> Enderecos { get; set; }


        //Navegação de Teste
        public ICollection<Endereco> Enderecos_ { get; set; }
        //

        //public string? EdificacaoIdTemp { get; set; }

        //public string? TerrenoIdTemp { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Complemento { get; set; }
        public string? AreaConstruida { get; set; }
        public string? AnoConstrucao { get; set; }

        public string? Numeracao { get; set; }
        public string? Caracteristica { get; set; }
        public string? Matricula { get; set; }
        public bool? TemProcessos { get; set; }
     
    }
}
