using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicDoctosApresentado
{
    public int IdDocApresentado { get; set; }

    public short? IdEmpresa { get; set; }

    public short? IdDocCrcf { get; set; }

    public int? IdPessoa { get; set; }

    public string? NrDocumento { get; set; }

    public DateTime? DtEmissao { get; set; }

    public DateTime? DtValidade { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public DateTime? DtApresentacao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public byte[]? ImDocumento { get; set; }

    public string? DsNomeImagem { get; set; }

    public string? DsExtesaoImagem { get; set; }

    public string? DsObservacoes { get; set; }

    public string? CdTipoCertidaoSit { get; set; }

    public virtual TbLicDoctosCrcf? IdDocCrcfNavigation { get; set; }

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }

    public virtual ICollection<TbLicCrcf> IdCrcfs { get; set; } = new List<TbLicCrcf>();
}
