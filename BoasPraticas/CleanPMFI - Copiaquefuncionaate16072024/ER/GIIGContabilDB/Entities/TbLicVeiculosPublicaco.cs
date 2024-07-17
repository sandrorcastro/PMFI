using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicVeiculosPublicaco
{
    public short IdVeiculoPublicacao { get; set; }

    public string? DsVeiculoPublicacao { get; set; }

    public string? FlOrgaoOficial { get; set; }

    public string? FlExigeContrato { get; set; }

    public string? FlMural { get; set; }

    public string? FlAtivo { get; set; }

    public virtual ICollection<TbGerOrgaoOficialPublicacao> TbGerOrgaoOficialPublicacaos { get; set; } = new List<TbGerOrgaoOficialPublicacao>();

    public virtual ICollection<TbLicContratoOrgaoOficialPublicacao> TbLicContratoOrgaoOficialPublicacaos { get; set; } = new List<TbLicContratoOrgaoOficialPublicacao>();

    public virtual ICollection<TbLicPublicaco> TbLicPublicacos { get; set; } = new List<TbLicPublicaco>();

    public virtual ICollection<TbSbsAditivo> TbSbsAditivos { get; set; } = new List<TbSbsAditivo>();

    public virtual ICollection<TbSbsSubvencaoSocial> TbSbsSubvencaoSocials { get; set; } = new List<TbSbsSubvencaoSocial>();
}
