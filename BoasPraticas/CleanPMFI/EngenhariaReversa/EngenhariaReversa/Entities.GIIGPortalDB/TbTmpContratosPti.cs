using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpContratosPti
    {
        public int? Id { get; set; }
        public string? NrCnpj { get; set; }
        public string? Administrador { get; set; }
        public string? CodigoContrato { get; set; }
        public string? CodigoLicitacao { get; set; }
        public string? Contratada { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
        public int? DiasAvencer { get; set; }
        public int? NumeroAditivoVigente { get; set; }
        public int? NumeroEmpenho { get; set; }
        public int? NumeroProcessos { get; set; }
        public string? DsObjeto { get; set; }
        public int? PrazoVigencia { get; set; }
        public string? SetorFiscalizacao { get; set; }
        public string? TipoSituacaoContrato { get; set; }
        public decimal? ValorDoContratoOriginal { get; set; }
        public decimal? ValorDoTermoAditivo { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}
