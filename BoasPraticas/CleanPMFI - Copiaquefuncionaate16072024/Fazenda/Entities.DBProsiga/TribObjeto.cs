using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribObjeto
{
    public int ObjetoId { get; set; }

    public byte[]? ObjConteudo { get; set; }

    public string? ObjExtensao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public virtual ICollection<TbConSolicitacaoInscricaoCmcdocumento> TbConSolicitacaoInscricaoCmcdocumentos { get; set; } = new List<TbConSolicitacaoInscricaoCmcdocumento>();

    public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; } = new List<TribAlvaraTermoDispenca>();

    public virtual ICollection<TribEmpresaAnexo> TribEmpresaAnexos { get; set; } = new List<TribEmpresaAnexo>();

    public virtual ICollection<TribFiscAutoInfracoesAnexo> TribFiscAutoInfracoesAnexos { get; set; } = new List<TribFiscAutoInfracoesAnexo>();

    public virtual ICollection<TribItbiexAnexo> TribItbiexAnexos { get; set; } = new List<TribItbiexAnexo>();

    public virtual ICollection<TribNotificacaoDum> TribNotificacaoDa { get; set; } = new List<TribNotificacaoDum>();

    public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; } = new List<TribNotificacaoDivida>();

    public virtual ICollection<TribProcPeticao> TribProcPeticaos { get; set; } = new List<TribProcPeticao>();
}
