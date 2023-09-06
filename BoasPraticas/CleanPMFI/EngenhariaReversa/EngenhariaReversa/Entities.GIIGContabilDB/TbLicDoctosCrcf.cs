using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicDoctosCrcf
    {
        public TbLicDoctosCrcf()
        {
            TbLicDoctosApresentados = new HashSet<TbLicDoctosApresentado>();
            IdCategoria = new HashSet<TbGerCategoriasPessoa>();
            IdTipoCrcfs = new HashSet<TbLicTipoCrcf>();
        }

        public short IdDocCrcf { get; set; }
        public string? NmDocCrcf { get; set; }
        public string? FlDocInibeEmissaoCrcf { get; set; }
        public string? DsTipoDocumento { get; set; }
        public string? DsCategoria { get; set; }
        public short? CdTc { get; set; }
        public int? IdPessoa { get; set; }

        public virtual ICollection<TbLicDoctosApresentado> TbLicDoctosApresentados { get; set; }

        public virtual ICollection<TbGerCategoriasPessoa> IdCategoria { get; set; }
        public virtual ICollection<TbLicTipoCrcf> IdTipoCrcfs { get; set; }
    }
}
