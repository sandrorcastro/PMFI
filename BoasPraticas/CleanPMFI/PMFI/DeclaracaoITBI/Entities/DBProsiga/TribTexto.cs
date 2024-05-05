using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTexto
{
    public long TextoId { get; set; }

    public string TextoDescricao { get; set; } = null!;

    /// <summary>
    /// Titulo do texto. Não obrigatório. (Esta sendo utilizado nas certidões negativas e positivas).
    /// </summary>
    public string TextoTitulo { get; set; } = null!;

    /// <summary>
    /// Nome da pessoa que assina o documento que o possui o texto.
    /// </summary>
    public string TextoNomeAssinatura { get; set; } = null!;

    /// <summary>
    /// Descricação do cargo da pessoa que assina o documento.
    /// </summary>
    public string TextoCargoAssinatura { get; set; } = null!;

    /// <summary>
    /// Imagem da assinatura da pessoa que assina o documento.
    /// </summary>
    public byte[]? TextoImagemAssinatura { get; set; }

    /// <summary>
    /// Nota de rodapé do documento que será impresso com o texto.
    /// </summary>
    public string TextoNotaRodape { get; set; } = null!;

    public int? DivId { get; set; }

    public string? TextoSuperior { get; set; }

    public virtual ICollection<AguaReqSolicitacaoServico> AguaReqSolicitacaoServicos { get; set; } = new List<AguaReqSolicitacaoServico>();

    public virtual ICollection<TribCertidaoDum> TribCertidaoDa { get; set; } = new List<TribCertidaoDum>();

    public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; } = new List<TribDividasImoEdital>();

    public virtual ICollection<TribDocumentosTipo> TribDocumentosTipos { get; set; } = new List<TribDocumentosTipo>();

    public virtual ICollection<TribLeisDesc> TribLeisDescs { get; set; } = new List<TribLeisDesc>();

    public virtual ICollection<TribNotificacaoDum> TribNotificacaoDa { get; set; } = new List<TribNotificacaoDum>();

    public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; } = new List<TribNotificacaoDivida>();

    public virtual ICollection<TribTipoBaixaTexto> TribTipoBaixaTextos { get; set; } = new List<TribTipoBaixaTexto>();
}
