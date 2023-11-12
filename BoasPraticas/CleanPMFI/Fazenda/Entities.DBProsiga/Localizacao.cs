using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Localizacao
{
    public int LocId { get; set; }

    public string? LocNome { get; set; }

    public string? LocFone { get; set; }

    public string? LocCep { get; set; }

    public string? LocEndereco { get; set; }

    public string? LocNumero { get; set; }

    public string? LocComplemento { get; set; }

    public string? LocBairro { get; set; }

    public string? LocCidade { get; set; }

    public string? LocUf { get; set; }

    public string? LocRespMatricula { get; set; }

    public string? LocRespNome { get; set; }

    public long? TipoLocId { get; set; }

    public virtual ICollection<Diviso> Divisos { get; set; } = new List<Diviso>();

    public virtual ICollection<EdumovimentoLotacao> EdumovimentoLotacaos { get; set; } = new List<EdumovimentoLotacao>();

    public virtual ICollection<Eduturma> Eduturmas { get; set; } = new List<Eduturma>();

    public virtual ICollection<LocSubLocal> LocSubLocals { get; set; } = new List<LocSubLocal>();

    public virtual ICollection<LocalFisico> LocalFisicos { get; set; } = new List<LocalFisico>();

    public virtual ICollection<RhcargoFuncaoLocal> RhcargoFuncaoLocals { get; set; } = new List<RhcargoFuncaoLocal>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiLocIdatuacaoNavigations { get; set; } = new List<RhdadosFuncionai>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiLocIdlotacaoNavigations { get; set; } = new List<RhdadosFuncionai>();

    public virtual ICollection<SocPasse> SocPasses { get; set; } = new List<SocPasse>();

    public virtual EdutipoLocal? TipoLoc { get; set; }

    public virtual ICollection<TribEditalCompra> TribEditalCompras { get; set; } = new List<TribEditalCompra>();
}
