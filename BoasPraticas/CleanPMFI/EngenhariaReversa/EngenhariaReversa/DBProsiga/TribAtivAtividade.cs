using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivAtividade
    {
        public TribAtivAtividade()
        {
            FissAtividadesDoctos = new HashSet<FissAtividadesDocto>();
            SerIturEmpresasSemCmcativs = new HashSet<SerIturEmpresasSemCmcativ>();
            Tbconsultapreviadocumentoresposta = new HashSet<Tbconsultapreviadocumentoresposta>();
            Tbconsultapreviagrauriscoresposta = new HashSet<Tbconsultapreviagrauriscoresposta>();
            Tbconsultapreviagrauriscos = new HashSet<Tbconsultapreviagraurisco>();
            Tbconsultapreviazoneamentoresposta = new HashSet<Tbconsultapreviazoneamentoresposta>();
            TbtribZonaZoneamentoAtividadePergunta = new HashSet<TbtribZonaZoneamentoAtividadePergunta>();
            TribAtivAtividadeDocumentos = new HashSet<TribAtivAtividadeDocumento>();
            TribAtivAtividadeGrauRiscoPergunta = new HashSet<TribAtivAtividadeGrauRiscoPergunta>();
            TribAtivAtividadeGrauRiscos = new HashSet<TribAtivAtividadeGrauRisco>();
            TribAtivTributosEmpresas = new HashSet<TribAtivTributosEmpresa>();
            TribAtividadeTipoAlvaraTributos = new HashSet<TribAtividadeTipoAlvaraTributo>();
            TribEmpresasAtivs = new HashSet<TribEmpresasAtiv>();
            TribZonaZoneamentoAtividades = new HashSet<TribZonaZoneamentoAtividade>();
            Servs = new HashSet<TribTiposServico>();
        }

        public string Atividade { get; set; } = null!;
        public string? AtividadeDenom { get; set; }
        public string? AtivClasse { get; set; }
        public string? AtividadeAutonomo { get; set; }
        public string? AtividadeCodAntigo { get; set; }
        /// <summary>
        /// informa se esta atividade deve ou não ser enquadrada como micro empresa
        /// </summary>
        public string? AtividadeEnquadrMicroEmpr { get; set; }
        /// <summary>
        /// Este campo foi criado pois existe no SMTR. (michimi)
        /// </summary>
        public decimal? AtividadeUffiacresc { get; set; }
        public int? AtSetId { get; set; }
        /// <summary>
        /// Marca se a atividade é padrão da tabela CNAE.
        /// </summary>
        public string? AtCnae { get; set; }
        /// <summary>
        /// Explicar os requisitos necessários para abertura de um empresa com a atividade.
        /// </summary>
        public string? AtRequisitos { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? AtivVedadaSimplesNacional { get; set; }
        public string? AtividadeRisco { get; set; }

        public virtual TribAtivSetor? AtSet { get; set; }
        public virtual TribAtivClasse? AtivClasseNavigation { get; set; }
        public virtual ICollection<FissAtividadesDocto> FissAtividadesDoctos { get; set; }
        public virtual ICollection<SerIturEmpresasSemCmcativ> SerIturEmpresasSemCmcativs { get; set; }
        public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; }
        public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; }
        public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; }
        public virtual ICollection<TribAtivAtividadeDocumento> TribAtivAtividadeDocumentos { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRisco> TribAtivAtividadeGrauRiscos { get; set; }
        public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; }
        public virtual ICollection<TribAtividadeTipoAlvaraTributo> TribAtividadeTipoAlvaraTributos { get; set; }
        public virtual ICollection<TribEmpresasAtiv> TribEmpresasAtivs { get; set; }
        public virtual ICollection<TribZonaZoneamentoAtividade> TribZonaZoneamentoAtividades { get; set; }

        public virtual ICollection<TribTiposServico> Servs { get; set; }
    }
}
