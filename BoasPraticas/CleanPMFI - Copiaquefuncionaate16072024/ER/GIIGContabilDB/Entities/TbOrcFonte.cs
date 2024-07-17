using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcFonte
{
    public int IdFonte { get; set; }

    public short IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string CdFonte { get; set; } = null!;

    public string? DsFonte { get; set; }

    public string? FlPadraoTce { get; set; }

    public string? DsTipoFonte { get; set; }

    public decimal? VlSaldoInicial { get; set; }

    public int? IdFonteSuperior { get; set; }

    public string? DsFonteRecurso { get; set; }

    public DateTime? DtCadastro { get; set; }

    public virtual ICollection<TbDspDespesaExtraOrcamentarium> TbDspDespesaExtraOrcamentaria { get; set; } = new List<TbDspDespesaExtraOrcamentarium>();

    public virtual ICollection<TbFinContrapartidasOpCredito> TbFinContrapartidasOpCreditoIdFonteContraPartidaNavigations { get; set; } = new List<TbFinContrapartidasOpCredito>();

    public virtual ICollection<TbFinContrapartidasOpCredito> TbFinContrapartidasOpCreditoIdFonteOpCreditoNavigations { get; set; } = new List<TbFinContrapartidasOpCredito>();

    public virtual ICollection<TbLdoLimitesAnual> TbLdoLimitesAnuals { get; set; } = new List<TbLdoLimitesAnual>();

    public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; } = new List<TbOrcDotaco>();

    public virtual ICollection<TbOrcReceitasFonte> TbOrcReceitasFontes { get; set; } = new List<TbOrcReceitasFonte>();

    public virtual ICollection<TbRecMovimentoReceitasDetalheDesmembra> TbRecMovimentoReceitasDetalheDesmembras { get; set; } = new List<TbRecMovimentoReceitasDetalheDesmembra>();
}
