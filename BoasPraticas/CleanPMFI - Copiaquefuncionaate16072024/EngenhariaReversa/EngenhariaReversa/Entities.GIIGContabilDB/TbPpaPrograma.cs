using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaPrograma
    {
        public TbPpaPrograma()
        {
            TbPpaIndicadores = new HashSet<TbPpaIndicadore>();
            TbPpaProgramasAcos = new HashSet<TbPpaProgramasAco>();
            TbPpaProgramasObjetivos = new HashSet<TbPpaProgramasObjetivo>();
            TbPpaProgramasPermissoesOrgaos = new HashSet<TbPpaProgramasPermissoesOrgao>();
        }

        public short IdEmpresa { get; set; }
        public short NrAnoPpa { get; set; }
        public short NrVersao { get; set; }
        public string CdPrograma { get; set; } = null!;
        public string? NmPrograma { get; set; }
        public bool? FlEfinalistico { get; set; }
        public string? DsObjetivo { get; set; }
        public string? DsPrograma { get; set; }
        public string? DsResultadosEsperado { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? DsMotivoCancelamento { get; set; }
        public string? DsTpComando { get; set; }

        public virtual TbPpaVerso Nr { get; set; } = null!;
        public virtual ICollection<TbPpaIndicadore> TbPpaIndicadores { get; set; }
        public virtual ICollection<TbPpaProgramasAco> TbPpaProgramasAcos { get; set; }
        public virtual ICollection<TbPpaProgramasObjetivo> TbPpaProgramasObjetivos { get; set; }
        public virtual ICollection<TbPpaProgramasPermissoesOrgao> TbPpaProgramasPermissoesOrgaos { get; set; }
    }
}
