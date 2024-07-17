using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissDocFiscaisOcorrencia
    {
        public long DocFisOcorrenciaId { get; set; }
        public long? DocFisId { get; set; }
        public string? SerieNome { get; set; }
        public string? ModNota { get; set; }
        public DateTime? DocFisDataPgto { get; set; }
        public DateTime? DocFisData { get; set; }
        public long? DocFisNumero { get; set; }
        public string? SitRecNome { get; set; }
        public decimal? DocFisValorTotNf { get; set; }
        public decimal? DocFisValorSerNf { get; set; }
        public decimal? DocFisValorImpNf { get; set; }
        public decimal? DocFisAliquotaImpNf { get; set; }
        public long? EmprCmc { get; set; }
        public long? EmprConId { get; set; }
        public string? EmprConNome { get; set; }
        public string? EmprConCnpjcpf { get; set; }
        public string? TipoDocNome { get; set; }
        public string? MovMotivo { get; set; }
        public string? NatOpDescricao { get; set; }
        public long? TomToPrId { get; set; }
        public string? TomTipoOpNome { get; set; }
        public long? TomConId { get; set; }
        public long? TomEmprCmc { get; set; }
        public string? TomConNome { get; set; }
        public string? TomConCnpjcpf { get; set; }
        public long? PrestToPrId { get; set; }
        public string? PrestTipoOpNome { get; set; }
        public long? PrestConId { get; set; }
        public long? PrestEmprCmc { get; set; }
        public string? PrestConNome { get; set; }
        public string? PrestConCnpjcpf { get; set; }
    }
}
