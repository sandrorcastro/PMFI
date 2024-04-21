using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscVistoria
    {
        public TribFiscVistoria()
        {
            TribFiscApreensos = new HashSet<TribFiscApreenso>();
            TribFiscEmbargoes = new HashSet<TribFiscEmbargo>();
            TribFiscInterdicos = new HashSet<TribFiscInterdico>();
            TribFiscNotificacos = new HashSet<TribFiscNotificaco>();
            TribFiscVistoriaItensVistoriados = new HashSet<TribFiscVistoriaItensVistoriado>();
            TribFiscVistoriasAtributos = new HashSet<TribFiscVistoriasAtributo>();
        }

        public int VistId { get; set; }
        public int? FiscOsid { get; set; }
        public short? VistAno { get; set; }
        public int? FiscalId { get; set; }
        public int TipoVistId { get; set; }
        public DateTime? VistDataAbertura { get; set; }
        public long? EdificacaoId { get; set; }
        public long? EmprCmc { get; set; }
        public long? ConId { get; set; }
        public string? VistObs { get; set; }
        public DateTime? VistDataFechamento { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? VistSituacao { get; set; }
        public string? VistMotivoSituacao { get; set; }
        public int? VistNumeroLaudo { get; set; }
        public int? VistNumero { get; set; }
        public string? VistNomeAssinatura { get; set; }
        public string? VistCpfrgassinatura { get; set; }
        public DateTime? VistDataNfinicial { get; set; }
        public DateTime? VistDataNffinal { get; set; }
        public long? VistNumNfinicial { get; set; }
        public long? VistNumNffinal { get; set; }
        public string? VistRelato { get; set; }
        public string? VistConsideracoes { get; set; }
        public int? NrProtocolo { get; set; }

        public virtual TribEdificaco? Edificacao { get; set; }
        public virtual TribEmpresa? EmprCmcNavigation { get; set; }
        public virtual TribFiscOrdemServico? FiscOs { get; set; }
        public virtual TribFiscFiscai? Fiscal { get; set; }
        public virtual TribFiscTiposVistorium TipoVist { get; set; } = null!;
        public virtual ICollection<TribFiscApreenso> TribFiscApreensos { get; set; }
        public virtual ICollection<TribFiscEmbargo> TribFiscEmbargoes { get; set; }
        public virtual ICollection<TribFiscInterdico> TribFiscInterdicos { get; set; }
        public virtual ICollection<TribFiscNotificaco> TribFiscNotificacos { get; set; }
        public virtual ICollection<TribFiscVistoriaItensVistoriado> TribFiscVistoriaItensVistoriados { get; set; }
        public virtual ICollection<TribFiscVistoriasAtributo> TribFiscVistoriasAtributos { get; set; }
    }
}
