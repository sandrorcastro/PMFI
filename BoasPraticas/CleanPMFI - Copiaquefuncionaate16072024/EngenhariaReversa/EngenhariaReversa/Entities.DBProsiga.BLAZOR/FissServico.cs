using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissServico
    {
        public FissServico()
        {
            FissServicoTipoServicos = new HashSet<FissServicoTipoServico>();
            FissServicoTributos = new HashSet<FissServicoTributo>();
            FissServicosAnexos = new HashSet<FissServicosAnexo>();
        }

        public long ServId { get; set; }
        public DateTime? ServData { get; set; }
        public long? EmprCmc { get; set; }
        public string? ServDespacho { get; set; }
        public long? ContadorId { get; set; }
        public string? ServSituacao { get; set; }
        public string? ServSolicitacao { get; set; }
        public string? ServImgAlt { get; set; }
        public string? ServImgAnt { get; set; }

        public virtual TribContador? Contador { get; set; }
        public virtual TribEmpresa? EmprCmcNavigation { get; set; }
        public virtual ICollection<FissServicoTipoServico> FissServicoTipoServicos { get; set; }
        public virtual ICollection<FissServicoTributo> FissServicoTributos { get; set; }
        public virtual ICollection<FissServicosAnexo> FissServicosAnexos { get; set; }
    }
}
