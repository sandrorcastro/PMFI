using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbGerPessoa
    {
        public int IdPessoa { get; set; }
        public string? DsTipoPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? NmFantasia { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NrRgIe { get; set; }
        public string? DsOrgaoExp { get; set; }
        public string? DsufExp { get; set; }
        public string? NrRegistroJuntaComercial { get; set; }
        public decimal? VlCapitalSocial { get; set; }
        public int? IdEndereco { get; set; }
        public string? NrPredial { get; set; }
        public string? DsComplEndereco { get; set; }
        public string? NrTelefones { get; set; }
        public string? DsEmail { get; set; }
        public string? DsSite { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsAtividade { get; set; }
        public string? FlMicroEmpresa { get; set; }
        public DateTime? DtRegistroJuntaComercial { get; set; }
        public string? DsObjetoContratual { get; set; }
        public string? DsCategoriaCadastramento { get; set; }
        public decimal? VlPatrimonioLiquido { get; set; }
        public decimal? NrIlcorrente { get; set; }
        public decimal? NrIlglobal { get; set; }
        public decimal? NrSolvenciaGeral { get; set; }
        public string? DsEntidadeProfissional { get; set; }
        public string? NrFax { get; set; }
        public string? DsOrigemCadastro { get; set; }
        public DateTime? DtEmissaoRg { get; set; }
        public DateTime? DtNascimento { get; set; }
        public DateTime? DtBaseTce { get; set; }
        public string? FlTratamentoDiferenciado { get; set; }
        public int? IdPessoaOrigem { get; set; }
    }
}
