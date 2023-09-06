using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTexto
    {
        public TribTexto()
        {
            AguaReqSolicitacaoServicos = new HashSet<AguaReqSolicitacaoServico>();
            TribCertidaoDa = new HashSet<TribCertidaoDum>();
            TribDividasImoEditals = new HashSet<TribDividasImoEdital>();
            TribDocumentosTipos = new HashSet<TribDocumentosTipo>();
            TribLeisDescs = new HashSet<TribLeisDesc>();
            TribNotificacaoDa = new HashSet<TribNotificacaoDum>();
            TribNotificacaoDivida = new HashSet<TribNotificacaoDivida>();
            TribTipoBaixaTextos = new HashSet<TribTipoBaixaTexto>();
        }

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

        public virtual ICollection<AguaReqSolicitacaoServico> AguaReqSolicitacaoServicos { get; set; }
        public virtual ICollection<TribCertidaoDum> TribCertidaoDa { get; set; }
        public virtual ICollection<TribDividasImoEdital> TribDividasImoEditals { get; set; }
        public virtual ICollection<TribDocumentosTipo> TribDocumentosTipos { get; set; }
        public virtual ICollection<TribLeisDesc> TribLeisDescs { get; set; }
        public virtual ICollection<TribNotificacaoDum> TribNotificacaoDa { get; set; }
        public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; }
        public virtual ICollection<TribTipoBaixaTexto> TribTipoBaixaTextos { get; set; }
    }
}
