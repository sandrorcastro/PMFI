using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCertidaoDaimovel
    {
        public int IdCertidaoDaimovel { get; set; }
        public long CertidaoDaid { get; set; }
        public int? EdificacaoId { get; set; }
        public string? NrInscricao { get; set; }
        public string? DsRefAnterior { get; set; }
        public string? TpLograouro { get; set; }
        public string? NmLogradouro { get; set; }
        public string? NrPredial { get; set; }
        public string? NmLoteamento { get; set; }
        public string? NrCep { get; set; }
        public string? NmCidade { get; set; }
        public string? DsUf { get; set; }
        public string? DsComplemento { get; set; }
        public long? IdVersao { get; set; }
    }
}
