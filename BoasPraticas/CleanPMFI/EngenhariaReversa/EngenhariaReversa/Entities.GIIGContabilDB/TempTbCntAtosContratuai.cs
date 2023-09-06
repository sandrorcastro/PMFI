using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbCntAtosContratuai
    {
        public int IdAtoContratual { get; set; }
        public int IdContrato { get; set; }
        public short IdTipoAtoContratual { get; set; }
        public int? NrAditivo { get; set; }
        public string? DsTipoAditivo { get; set; }
        public string? FlPrevisaoContratual { get; set; }
        public DateTime? DtTermo { get; set; }
        public DateTime? DtPublicacaoTermo { get; set; }
        public decimal? VlAditivo { get; set; }
        public decimal? VlAtualizadoContrato { get; set; }
        public DateTime? DtNovaTermino { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdPessoaRepresentante { get; set; }
        public string? DsMotivo { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdNumeroAto { get; set; }
        public short? IdTipoOperacaoAto { get; set; }
        public int? IdPessoaAtoContratual { get; set; }
        public short? IdTipoMotivoRescisao { get; set; }
        public string? CdTcm { get; set; }
        public DateTime? DtEscrituracao { get; set; }
        public int? IdAtoContratualOrigem { get; set; }
    }
}
