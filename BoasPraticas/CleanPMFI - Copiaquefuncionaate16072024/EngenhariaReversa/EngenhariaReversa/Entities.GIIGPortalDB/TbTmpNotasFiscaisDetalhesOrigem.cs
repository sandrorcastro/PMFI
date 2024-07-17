using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpNotasFiscaisDetalhesOrigem
    {
        public int IdNotasFiscaisDetalhes { get; set; }
        public string? MaterialServico { get; set; }
        public string? CodigoNotaFiscal { get; set; }
        public string? Produto { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? ValorUnitario { get; set; }
        public int? Idpessoa { get; set; }
        public string? NmPessoa { get; set; }
        public int? Idempenho { get; set; }
        public short? NrEmpenho { get; set; }
        public DateTime? DtExecucao { get; set; }
    }
}
