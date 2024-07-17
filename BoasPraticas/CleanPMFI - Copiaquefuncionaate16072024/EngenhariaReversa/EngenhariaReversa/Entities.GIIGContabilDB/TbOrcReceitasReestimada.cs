using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcReceitasReestimada
    {
        public int IdReestimativa { get; set; }
        public int? IdReceita { get; set; }
        public DateTime? DtLancamento { get; set; }
        public decimal? VlReestimado { get; set; }
        public string? DsObservacoes { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsTipo { get; set; }
        public short? IdTipoAtualizacaoOrcamentaria { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }

        public virtual TbOrcReceita? IdReceitaNavigation { get; set; }
        public virtual TbOrcTipoAtualizacaoOrcamentarium? IdTipoAtualizacaoOrcamentariaNavigation { get; set; }
    }
}
