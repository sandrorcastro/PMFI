using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicVeiculosPublicaco
    {
        public TbLicVeiculosPublicaco()
        {
            TbGerOrgaoOficialPublicacaos = new HashSet<TbGerOrgaoOficialPublicacao>();
            TbLicContratoOrgaoOficialPublicacaos = new HashSet<TbLicContratoOrgaoOficialPublicacao>();
            TbLicPublicacos = new HashSet<TbLicPublicaco>();
            TbSbsAditivos = new HashSet<TbSbsAditivo>();
            TbSbsSubvencaoSocials = new HashSet<TbSbsSubvencaoSocial>();
        }

        public short IdVeiculoPublicacao { get; set; }
        public string? DsVeiculoPublicacao { get; set; }
        public string? FlOrgaoOficial { get; set; }
        public string? FlExigeContrato { get; set; }
        public string? FlMural { get; set; }
        public string? FlAtivo { get; set; }

        public virtual ICollection<TbGerOrgaoOficialPublicacao> TbGerOrgaoOficialPublicacaos { get; set; }
        public virtual ICollection<TbLicContratoOrgaoOficialPublicacao> TbLicContratoOrgaoOficialPublicacaos { get; set; }
        public virtual ICollection<TbLicPublicaco> TbLicPublicacos { get; set; }
        public virtual ICollection<TbSbsAditivo> TbSbsAditivos { get; set; }
        public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; }
    }
}
