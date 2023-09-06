using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpNotasFiscaisOrigem
    {
        public int IdNotasFiscais { get; set; }
        public string? CodigoNotaFiscal { get; set; }
        public string? CnpjFornecedor { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string? NumeroSerie { get; set; }
        public decimal? ValorTotal { get; set; }
        public int? Idpessoa { get; set; }
        public string? NmPessoa { get; set; }
        public int? Idempenho { get; set; }
        public short? NrEmpenho { get; set; }
        public DateTime? DtExecucao { get; set; }
    }
}
