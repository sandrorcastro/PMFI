using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaUnidadesMedidum
    {
        public TbPlaUnidadesMedidum()
        {
            TbCapConvAuxProgramas = new HashSet<TbCapConvAuxPrograma>();
            TbPlaIndicadoresMovimentos = new HashSet<TbPlaIndicadoresMovimento>();
            TbPlaIndicadoresSimplificados = new HashSet<TbPlaIndicadoresSimplificado>();
            TbPlaObjetivosMetasLocalizadores = new HashSet<TbPlaObjetivosMetasLocalizadore>();
        }

        public short IdUnidadeMedida { get; set; }
        public string? DsUnidadeMedida { get; set; }
        public short? IdUnidadeMedidaPadrao { get; set; }
        public short? NrAnoLimite { get; set; }

        public virtual TbPlaUnidadesMedidasPadrao? IdUnidadeMedidaPadraoNavigation { get; set; }
        public virtual ICollection<TbCapConvAuxPrograma> TbCapConvAuxProgramas { get; set; }
        public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; }
        public virtual ICollection<TbPlaIndicadoresSimplificado> TbPlaIndicadoresSimplificados { get; set; }
        public virtual ICollection<TbPlaObjetivosMetasLocalizadore> TbPlaObjetivosMetasLocalizadores { get; set; }
    }
}
