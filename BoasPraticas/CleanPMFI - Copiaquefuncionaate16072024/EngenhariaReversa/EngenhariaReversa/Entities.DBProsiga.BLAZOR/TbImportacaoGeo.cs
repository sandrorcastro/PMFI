using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbImportacaoGeo
    {
        public int IdImportacaoGeo { get; set; }
        public string NrInscricao { get; set; } = null!;
        public string? NmProprietario { get; set; }
        public string? TpLogradouro { get; set; }
        public string? DsEndereco { get; set; }
        public string? NrNumeroPredial { get; set; }
        public string? DsComplemento { get; set; }
        public string? NmBairro { get; set; }
        public string? NmCidade { get; set; }
        public string? NmUf { get; set; }
        public string? CdQuadra { get; set; }
        public string? CdLote { get; set; }
        public string? NmLoteamento { get; set; }
        public string? DsSituacao { get; set; }
        public string? DsCarecteristica { get; set; }
        public string? NrNumeroOficio { get; set; }
        public string? NrMatricula { get; set; }
        public int? NrNumeroPavimento { get; set; }
        public decimal? VlMetragemConstruida { get; set; }
        public decimal? VlMetragemAreaCoberta { get; set; }
        public int? NrIdadeAparente { get; set; }
        public string? NrEconomia { get; set; }
        public string? DsDenominacaoPredial { get; set; }
        public bool FlImportado { get; set; }
        public DateTime DtInclusao { get; set; }
    }
}
