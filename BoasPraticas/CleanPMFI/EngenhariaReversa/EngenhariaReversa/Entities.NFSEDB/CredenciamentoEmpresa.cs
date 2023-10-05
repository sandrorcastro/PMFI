using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class CredenciamentoEmpresa
    {
        public int IdCredenciamento { get; set; }
        public int IdEmpresa { get; set; }
        public int IdContribuinte { get; set; }
        public string Situacao { get; set; } = null!;
        public string IdUsuario { get; set; } = null!;
        public DateTime DtInclusao { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DtDescredenciamento { get; set; }
        public int Idcontribuinte1 { get; set; }
        public string? NmContribuinte { get; set; }
        public string? CpfCnpjContribuinte { get; set; }
        public string TipoContribuinte { get; set; } = null!;
        public int? IdCidadeContribuinte { get; set; }
        public string? CepCotribuinte { get; set; }
        public string? RuaCotribuinte { get; set; }
        public string? NumeroCotribuinte { get; set; }
        public string? ConplementoCotribuinte { get; set; }
        public string? BairroCotribuinte { get; set; }
        public string? CmcCotribuinte { get; set; }
        public string? EmailCotribuinte { get; set; }
        public string? FoneCotribuinte { get; set; }
        public string? EnderecoCorrespondenciaCotribuinte { get; set; }
        public string? NumeroCorrespondenciaCotribuinte { get; set; }
        public string? Stfax { get; set; }
        public string? IeCotribuinte { get; set; }
        public string? IiCotribuinte { get; set; }
        public DateTime? DtCadastroCotribuinte { get; set; }
        public int? CidadeCorrespondenciaCotribuinte { get; set; }
        public string? ComplementoCorrespondenciaCotribuinte { get; set; }
        public string? BairroCorrespondenciaCotribuinte { get; set; }
        public string? CepCorrespondenciaCotribuinte { get; set; }
        public string SituacaoEmpresa { get; set; } = null!;
        public string? CrcEmpresa { get; set; }
        public string SubTributarioEmpresa { get; set; } = null!;
        public string? SimNacionalEmpresa { get; set; }
        public int? IdMatrizEmpresa { get; set; }
        public DateTime? DtAberturaEmpresa { get; set; }
        public string? NumProcessoAberturaEmpresa { get; set; }
        public string? CpfCnpjContadorEmpresa { get; set; }
        public string? EnderecoContadorEmpresa { get; set; }
        public string? TelefoneContadorEmpresa { get; set; }
        public string? NomeContadorEmpresa { get; set; }
    }
}
