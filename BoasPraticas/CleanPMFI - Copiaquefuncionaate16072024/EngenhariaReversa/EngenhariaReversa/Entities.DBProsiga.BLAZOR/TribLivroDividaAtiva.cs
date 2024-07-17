using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribLivroDividaAtiva
    {
        public TribLivroDividaAtiva()
        {
            TribCertidaoDa = new HashSet<TribCertidaoDum>();
            TribCertidaoDalivros = new HashSet<TribCertidaoDalivro>();
            TribNotificacaoDa = new HashSet<TribNotificacaoDum>();
        }

        /// <summary>
        /// Numero do lançamento da divida em da
        /// </summary>
        public long LivroDaid { get; set; }
        /// <summary>
        /// numero da folha do livro
        /// </summary>
        public int? LivroDafolha { get; set; }
        /// <summary>
        /// numero de sequencia 
        /// </summary>
        public int? LivroDaseq { get; set; }
        /// <summary>
        /// identificação da divida
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        /// <summary>
        /// numero do livro
        /// </summary>
        public long? LivroDanumero { get; set; }
        public DateTime? LivroDadataInscricao { get; set; }
        public decimal? LivroDamultaDa { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        /// <summary>
        /// Informa se o Livro esta Normal ou Cancelado (estorno de DA)
        /// </summary>
        public string LivroDasituacao { get; set; } = null!;
        public short? LivroDaanoTermo { get; set; }
        public int? LivroDanumeroTermo { get; set; }
        public string? LivroDamotivo { get; set; }
        public DateTime? LivroDadataCancelamento { get; set; }
        public string? LivroDausuarioCancelamento { get; set; }
        public string? LivroDamotivoCancelamento { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual ICollection<TribCertidaoDum> TribCertidaoDa { get; set; }
        public virtual ICollection<TribCertidaoDalivro> TribCertidaoDalivros { get; set; }
        public virtual ICollection<TribNotificacaoDum> TribNotificacaoDa { get; set; }
    }
}
