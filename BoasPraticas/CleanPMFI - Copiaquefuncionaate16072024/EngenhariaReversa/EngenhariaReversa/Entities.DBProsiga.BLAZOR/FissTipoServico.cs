using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissTipoServico
    {
        public FissTipoServico()
        {
            FissServicoTipoServicos = new HashSet<FissServicoTipoServico>();
            FissTipoServicoTributos = new HashSet<FissTipoServicoTributo>();
        }

        public long ServTpId { get; set; }
        public string? ServTpDescricao { get; set; }
        public string? ServTpAltCadEmpresa { get; set; }
        public string? ServTpGeraProtocolo { get; set; }
        public int? TipoProId { get; set; }
        public int? DivId { get; set; }

        public virtual ICollection<FissServicoTipoServico> FissServicoTipoServicos { get; set; }
        public virtual ICollection<FissTipoServicoTributo> FissTipoServicoTributos { get; set; }
    }
}
