using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblRelcomparativoemissaonotum
    {
        public long Idnfse { get; set; }
        public decimal? Vlservicos { get; set; }
        public decimal? Vltotaliss { get; set; }
        public byte? Mes { get; set; }
        public short? Ano { get; set; }
        public DateTime? Datahomologacao { get; set; }
        public string? Situacaohomologacao { get; set; }
        public DateTime? Dtcompetencia { get; set; }
        public string? Idservico { get; set; }
        public byte? Idregime { get; set; }
        public string? Stim { get; set; }
        public string? Stcpfcnpj { get; set; }
        public string? Stnome { get; set; }
        public int? Idempresa { get; set; }
        public string? Stnomecidade { get; set; }
        public string? Stufcidade { get; set; }
        public string? Stcepcontribuinte { get; set; }
        public string? StenderecoLogr { get; set; }
        public string? StenderecoBairro { get; set; }
        public string? StenderecoNumero { get; set; }
        public string? Emprsituacaodescricao { get; set; }
        public string? IdcnaeSubclasse { get; set; }
        public string? Stsituacaonf { get; set; }
        public string? SttomCpfcnpj { get; set; }
        public long? Idnfsecontratos { get; set; }
        public byte? Idoperacao { get; set; }
    }
}
