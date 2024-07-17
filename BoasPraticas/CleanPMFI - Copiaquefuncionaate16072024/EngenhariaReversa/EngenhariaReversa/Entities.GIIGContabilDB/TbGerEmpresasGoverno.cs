using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerEmpresasGoverno
    {
        public TbGerEmpresasGoverno()
        {
            TbDspEstornosEmpenhos = new HashSet<TbDspEstornosEmpenho>();
            TbFinContasContabeisLancamentosAnalisadors = new HashSet<TbFinContasContabeisLancamentosAnalisador>();
            TbGerCargosServidores = new HashSet<TbGerCargosServidore>();
            TbGerEmpresasGovAnosContabils = new HashSet<TbGerEmpresasGovAnosContabil>();
            TbLdoLimitesAnuals = new HashSet<TbLdoLimitesAnual>();
            TbLicLicitacos = new HashSet<TbLicLicitaco>();
            TbOrcAtualizacoesMonetariaOrcamentos = new HashSet<TbOrcAtualizacoesMonetariaOrcamento>();
            TbOrcOrgaos = new HashSet<TbOrcOrgao>();
            TbOrcProgramas = new HashSet<TbOrcPrograma>();
            TbRecMovimentoReceita = new HashSet<TbRecMovimentoReceita>();
        }

        public short Idempresa { get; set; }
        public string? DsTipoAdm { get; set; }
        /// <summary>
        /// Se é Prefeitura/Câmara/Autarquia/Previência
        /// </summary>
        public string? DsTipoEmpresa { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public byte[]? ImLogo { get; set; }
        public int? CdTce { get; set; }
        public int? Idendereco { get; set; }
        public int? NrPredial { get; set; }
        public string? DsComplEndereco { get; set; }
        public string? DsEmail { get; set; }
        public string? DsSite { get; set; }
        public string? DsNomeLogo { get; set; }
        public string? DsExtensaoLogo { get; set; }
        public string? FlCamaraCentralizada { get; set; }
        public int? NrHabitantes { get; set; }
        public byte[]? ImMarcaDagua { get; set; }
        public string? DsFone { get; set; }
        public string? NrFax { get; set; }
        public string? DsSigla { get; set; }
        public string? CdIbge { get; set; }

        public virtual TbGerEndereco? IdenderecoNavigation { get; set; }
        public virtual ICollection<TbDspEstornosEmpenho> TbDspEstornosEmpenhos { get; set; }
        public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; }
        public virtual ICollection<TbGerCargosServidore> TbGerCargosServidores { get; set; }
        public virtual ICollection<TbGerEmpresasGovAnosContabil> TbGerEmpresasGovAnosContabils { get; set; }
        public virtual ICollection<TbLdoLimitesAnual> TbLdoLimitesAnuals { get; set; }
        public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; }
        public virtual ICollection<TbOrcAtualizacoesMonetariaOrcamento> TbOrcAtualizacoesMonetariaOrcamentos { get; set; }
        public virtual ICollection<TbOrcOrgao> TbOrcOrgaos { get; set; }
        public virtual ICollection<TbOrcPrograma> TbOrcProgramas { get; set; }
        public virtual ICollection<TbRecMovimentoReceita> TbRecMovimentoReceita { get; set; }
    }
}
