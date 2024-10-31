using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TempMaioresDevedoresContribuinte
    {
        public string? Inscricao { get; set; }
        public string? Nome { get; set; }
        public decimal? ValorPrincipal { get; set; }
        public decimal? CorrecaoMonetaria { get; set; }
        public decimal? Multa { get; set; }
        public decimal? MultaDividaAtiva { get; set; }
        public decimal? Juros { get; set; }
        public string? Endereco { get; set; }
        public string? EndNumero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Telefone { get; set; }
        public string? TelefoneResidencial { get; set; }
        public string? TelefoneComercial { get; set; }
        public string? TelefoneCelular { get; set; }
    }
}
