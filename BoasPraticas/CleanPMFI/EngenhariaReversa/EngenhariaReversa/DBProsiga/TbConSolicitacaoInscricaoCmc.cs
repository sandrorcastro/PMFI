using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmc
    {
        public TbConSolicitacaoInscricaoCmc()
        {
            TbConSolicitacaoInscricaoAtividades = new HashSet<TbConSolicitacaoInscricaoAtividade>();
            TbConSolicitacaoInscricaoCmcdespachos = new HashSet<TbConSolicitacaoInscricaoCmcdespacho>();
            TbConSolicitacaoInscricaoCmcdocumentos = new HashSet<TbConSolicitacaoInscricaoCmcdocumento>();
            TbConSolicitacaoInscricaoCmcvigilanciaSanitaria = new HashSet<TbConSolicitacaoInscricaoCmcvigilanciaSanitarium>();
            TbConSolicitacaoInscricaoSocios = new HashSet<TbConSolicitacaoInscricaoSocio>();
        }

        public long IdSolicitacaoInscricao { get; set; }
        public string? NrLocalizadorAlvara { get; set; }
        public int? ConsId { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public long? EdificacaoId { get; set; }
        public string? DsTipoContribuinte { get; set; }
        public string? NrCnpjCpf { get; set; }
        public string? DsRazaoSocial { get; set; }
        public string? NmFantasia { get; set; }
        public string? NrTelefone { get; set; }
        public int? IdEndereco { get; set; }
        public string? NrPredial { get; set; }
        public string? DsComplementoEndereco { get; set; }
        public long? ContadorId { get; set; }
        public long? NrRegistroJucepar { get; set; }
        public DateTime? DtRegistroJucepar { get; set; }
        public decimal? NrAreaCobertaM2 { get; set; }
        public decimal? NrAreaAbertaM2 { get; set; }
        public int? EmprTipoId { get; set; }
        public int? EmprConstitId { get; set; }
        public int? EmprCaracId { get; set; }
        public bool? FlDomicilioTributario { get; set; }
        public bool? FlEnquadraSimplesNacional { get; set; }
        public string? DsAtividadeAlvara { get; set; }
        public string? DsRestricoes { get; set; }
        public long? NrLaudoBombeiro { get; set; }
        public int? NrAno { get; set; }
        public DateTime? DtValidade { get; set; }
        public DateTime? DtVistoria { get; set; }
        public DateTime? DtInscricao { get; set; }
        public string? DsOrigemInscricao { get; set; }
        public string? DsSituacaoInscricao { get; set; }
        public long? ConId { get; set; }
        public bool? FlMei { get; set; }
        public bool FlDemaisEmpresas { get; set; }
        public string? DsEmail { get; set; }
        public string? DsEmailContador { get; set; }
        public string? DsTipoSolicitacao { get; set; }
        public string? DsTiposAlteracao { get; set; }
        public long? EmprCmc { get; set; }
        public long? IdAlvara { get; set; }
        public int? NrAnoProtocolo { get; set; }
        public int? NrSequenciaProtocolo { get; set; }
        public bool? FlExpirado { get; set; }
        public string? NrJucepar { get; set; }
        public DateTime? DtJucepar { get; set; }
        public byte? EmprRegime { get; set; }
        public DateTime? EmprDataAdesao { get; set; }
        public decimal? EmprAlicotaPrincipal { get; set; }
        public decimal? EmprValorEstimado { get; set; }
        public string? EmprTipoEmpresa { get; set; }
        public decimal? EmprValorMensal { get; set; }
        public string? EmprSubstitutoTributario { get; set; }
        public string? EmprEmpresaPublica { get; set; }
        public DateTime? Dtinclusao { get; set; }
        public string? Dsarquivoxml { get; set; }

        public virtual TribEmpresasTipoCaracteristica? EmprCarac { get; set; }
        public virtual TribEmpresasTipoConstituicao? EmprConstit { get; set; }
        public virtual Cep? IdEnderecoNavigation { get; set; }
        public virtual ICollection<TbConSolicitacaoInscricaoAtividade> TbConSolicitacaoInscricaoAtividades { get; set; }
        public virtual ICollection<TbConSolicitacaoInscricaoCmcdespacho> TbConSolicitacaoInscricaoCmcdespachos { get; set; }
        public virtual ICollection<TbConSolicitacaoInscricaoCmcdocumento> TbConSolicitacaoInscricaoCmcdocumentos { get; set; }
        public virtual ICollection<TbConSolicitacaoInscricaoCmcvigilanciaSanitarium> TbConSolicitacaoInscricaoCmcvigilanciaSanitaria { get; set; }
        public virtual ICollection<TbConSolicitacaoInscricaoSocio> TbConSolicitacaoInscricaoSocios { get; set; }
    }
}
