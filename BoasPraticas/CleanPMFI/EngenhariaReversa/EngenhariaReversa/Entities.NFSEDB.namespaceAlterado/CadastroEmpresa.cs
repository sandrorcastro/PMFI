using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class CadastroEmpresa
    {
        public int IdEmpresa { get; set; }
        public int? IdContribuinte { get; set; }
        public string? CrcEmpresa { get; set; }
        public string? SubTributacaoEmpresa { get; set; }
        public string? TipoTributacaoEmpresa { get; set; }
        public int? IdMatrizEmpresa { get; set; }
        public DateTime? DtAberturaEmpresa { get; set; }
        public string? NumProcessoAberturaEmpresa { get; set; }
        public string? CpfCnpjContadorEmpresa { get; set; }
        public string? RuaContadorEmpresa { get; set; }
        public string? TelefoneContadorEmpresa { get; set; }
        public string? NomeContadorEmpresa { get; set; }
        public string IdCnaeSubClasseEmpresa { get; set; } = null!;
        public byte IdOperacaoEmpresaEmpresa { get; set; }
        public string? IdServicoEmpresa { get; set; }
        public string? MotivoEmpresa { get; set; }
        public string? IdUsuarioEmpresa { get; set; }
        public int IdHistoricoEmpresa { get; set; }
        public DateTime DtEntradaHistorico { get; set; }
        public DateTime? DtSaidaHistorico { get; set; }
        public decimal? ValorEstimadoHistorico { get; set; }
        public decimal? AliquotaPrincipalHistorico { get; set; }
        public decimal? ValorMensalHistorico { get; set; }
        public byte? IdOperacao { get; set; }
        public string? DescricaoOperacao { get; set; }
        public string? ServidorForaOperacao { get; set; }
        public string? NaturezaPadraoOperacao { get; set; }
        public string? NaturezaEspecialOperacao { get; set; }
        public string? DescricaoServico { get; set; }
        public decimal? AliquotaServico { get; set; }
        public string? RequolimentoMunicipioServico { get; set; }
        public string? SofreReducaoServico { get; set; }
        public string? VetadoServico { get; set; }
        public string? ObrigaRetencaoMunServico { get; set; }
        public string? ObrigaRetencaoForaServico { get; set; }
        public string? BaseLegalServico { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? Cpfcnpj { get; set; }
        public string? TipoPessoa { get; set; }
    }
}
