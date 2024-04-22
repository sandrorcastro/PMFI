using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudePacienteXxxxxx
    {
        public SaudePacienteXxxxxx()
        {
            SaudeAcsPacientes = new HashSet<SaudeAcsPaciente>();
            SaudeItensAgenda = new HashSet<SaudeItensAgendum>();
        }

        public long IdPaciente { get; set; }
        public string? NomePaciente { get; set; }
        public string? SexoPaciente { get; set; }
        public DateTime? DtNascPaciente { get; set; }
        public string? NomePai { get; set; }
        public string? NomeMae { get; set; }
        public string? EmailPaciente { get; set; }
        public string? RgPaciente { get; set; }
        public DateTime? DtEmissaoRg { get; set; }
        public string? OrgEmissorRg { get; set; }
        public string? UforgEmissorRg { get; set; }
        public string? CtpsPaciente { get; set; }
        public DateTime? DtEmissaoCtps { get; set; }
        public string? SerieCtps { get; set; }
        public string? Ufctps { get; set; }
        public string? CpfPaciente { get; set; }
        public DateTime? DtEmissaoCpf { get; set; }
        public string? PispasepPaciente { get; set; }
        public DateTime? DtEmissaoPis { get; set; }
        public string? CertidaoPaciente { get; set; }
        public DateTime? DtEmissaoCertidao { get; set; }
        public string? CartorioCertidao { get; set; }
        public string? LivroCertidao { get; set; }
        public string? FolhasCertidao { get; set; }
        public string? TermoCertidao { get; set; }
        public int? IdNacionalidade { get; set; }
        public string? IdProfissao { get; set; }
        public DateTime? EntradaPais { get; set; }
        public int? IdNaturalidade { get; set; }
        public string? IdProntuario { get; set; }
        public string? FarmaciaAmiga { get; set; }
        public string? Observacao { get; set; }
        public string? CodigoSus { get; set; }
        public string? FoneResidencia { get; set; }
        public string? FoneComercial { get; set; }
        public string? FoneCelular { get; set; }
        public string? FoneObservacoes { get; set; }
        public long IdEndereco { get; set; }
        public string? NrPredial { get; set; }
        public string? EnderecoComplemento { get; set; }
        public string? GrauInstrucao { get; set; }
        public string? EstadoCivil { get; set; }

        public virtual Cidade? IdNaturalidadeNavigation { get; set; }
        public virtual ICollection<SaudeAcsPaciente> SaudeAcsPacientes { get; set; }
        public virtual ICollection<SaudeItensAgendum> SaudeItensAgenda { get; set; }
    }
}
