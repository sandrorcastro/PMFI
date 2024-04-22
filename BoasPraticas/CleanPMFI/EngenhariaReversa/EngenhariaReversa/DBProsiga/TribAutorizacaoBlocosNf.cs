using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAutorizacaoBlocosNf
    {
        public TribAutorizacaoBlocosNf()
        {
            TribRecolhimentoBlocosNfs = new HashSet<TribRecolhimentoBlocosNf>();
        }

        public int AutNfid { get; set; }
        public DateTime? AutNfdata { get; set; }
        public int? AutNfde { get; set; }
        public int? AutNfate { get; set; }
        public string? AutNfserie { get; set; }
        public long? EmprCmc { get; set; }
        /// <summary>
        /// Notas Fiscais ou Livro
        /// </summary>
        public string? AutNftipoDoc { get; set; }
        /// <summary>
        /// Numero do Livro quando for o caso
        /// </summary>
        public int? AutNfnumLivro { get; set; }
        /// <summary>
        /// Informar o identificação da grafica no cadastro de contribuintes
        /// </summary>
        public long? ConId { get; set; }
        public string? AutNfobservacao { get; set; }
        public int? AutNfqtdeBlocos { get; set; }
        public DateTime? AutNfdataCancelamento { get; set; }
        public DateTime? AutNfdataVencimento { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? AutStatus { get; set; }
        public string? AutJustificativa { get; set; }
        public DateTime? AutDtAutorizacao { get; set; }
        public DateTime? AutDtConclusao { get; set; }
        public long? ConIdgrafica { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual Contribuinte? ConIdgraficaNavigation { get; set; }
        public virtual TribEmpresa? EmprCmcNavigation { get; set; }
        public virtual ICollection<TribRecolhimentoBlocosNf> TribRecolhimentoBlocosNfs { get; set; }
    }
}
