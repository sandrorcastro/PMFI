using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTipoAtualizacaoOrcamentarium
    {
        public TbOrcTipoAtualizacaoOrcamentarium()
        {
            TbOrcAtualizacoesMonetariaOrcamentos = new HashSet<TbOrcAtualizacoesMonetariaOrcamento>();
            TbOrcReceitasReestimada = new HashSet<TbOrcReceitasReestimada>();
        }

        public short IdTipoAtualizacaoOrcamentaria { get; set; }
        public string? DsTipoAtualizacaoOrcamentaria { get; set; }
        public string? TpGrupo { get; set; }

        public virtual ICollection<TbOrcAtualizacoesMonetariaOrcamento> TbOrcAtualizacoesMonetariaOrcamentos { get; set; }
        public virtual ICollection<TbOrcReceitasReestimada> TbOrcReceitasReestimada { get; set; }
    }
}
