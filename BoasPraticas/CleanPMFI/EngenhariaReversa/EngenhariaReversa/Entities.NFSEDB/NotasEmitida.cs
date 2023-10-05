using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NotasEmitida
    {
        public long IdNota { get; set; }
        public int? IdEmpresa { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Cmc { get; set; }
        public int? NumeroNota { get; set; }
        public string? IdIdentificadorNota { get; set; }
        public DateTime? DataNota { get; set; }
        public byte? IdNaturezaOperacaoNota { get; set; }
        public byte? Idregime { get; set; }
        public string SimplesNacionalNota { get; set; } = null!;
        public int? MesCompetencia { get; set; }
        public int? AnoCompetencia { get; set; }
        public DateTime? DataCompetencia { get; set; }
        public long? IdSubstitutoNota { get; set; }
        public string? OutrasInformacoesNota { get; set; }
        public string? IdcnaeSubclasse { get; set; }
        public int? IdpreIdcidade { get; set; }
        public string? IdTributacaoMunicipioNota { get; set; }
        public string? ServicoDescricaoNota { get; set; }
        public string? IdServicoNota { get; set; }
        public decimal? AliquotaNota { get; set; }
        public decimal? BaseCalculoNota { get; set; }
        public decimal? DescontoCondicionadoNota { get; set; }
        public decimal? DescontoIncondicionadoNota { get; set; }
        public string? IsRetidoNota { get; set; }
        public decimal? OutrasRetencoesNota { get; set; }
        public decimal? CofinsNota { get; set; }
        public decimal? IofNota { get; set; }
        public decimal? CsllNota { get; set; }
        public decimal? DeducoesNota { get; set; }
        public decimal? InssNota { get; set; }
        public decimal? IrNota { get; set; }
        public decimal? TotalIssNota { get; set; }
        public decimal? Vlissretido { get; set; }
        public decimal? TotalLiquidoNota { get; set; }
        public decimal? PisNota { get; set; }
        public decimal? ServicosNota { get; set; }
        public decimal? CreditoNota { get; set; }
        public int? IdMunGeradorNota { get; set; }
        public string? CeiNota { get; set; }
        public string? NumeroArtigoNota { get; set; }
        public string? SituacaoNota { get; set; }
        public string? EmailNota { get; set; }
        public string? IdUsuarioInclusao { get; set; }
        public string? RecolheIssInclusaoNota { get; set; }
        public byte IdNaturezaOperacao { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string Stservforamuni { get; set; } = null!;
        public string PadraoNaturezaOperacao { get; set; } = null!;
        public string EspecialNaturezaOperacao { get; set; } = null!;
        public string ExigeSuspensaNaturezaOperacao { get; set; } = null!;
        public int? IdContribuinteEmpresa { get; set; }
        public string? SituacaoContribuinteEmpresa { get; set; }
        public string? CrcContribuinteEmpresa { get; set; }
        public byte IdRegime1 { get; set; }
        public string? SimNacionalEmpresa { get; set; }
        public string RegimePrestador { get; set; } = null!;
        public string RegimeNota { get; set; } = null!;
        public string? DescricaoRegime { get; set; }
        public string? TipoAliquotaRegime { get; set; }
        public string SimplesNacionalRegime { get; set; } = null!;
        public byte? NumeroOrdemRegime { get; set; }
        public string? IdServiço { get; set; }
        public string? DescricaoServiço { get; set; }
        public decimal? AliquotaServico { get; set; }
        public string? RecolherServico { get; set; }
        public string? SofreReducaoServico { get; set; }
        public string? VetadoServico { get; set; }
        public string? ObrigaRetencaoMunServico { get; set; }
        public string? Stobrigaretencaofora { get; set; }
        public int? IdCidadePrestador { get; set; }
        public string? NomeCidadePrestador { get; set; }
        public string? UfPrestador { get; set; }
        public string? CodIbeCidadePrestador { get; set; }
        public string? Cmctomador { get; set; }
        public string? NomeTomador { get; set; }
        public string? Cpfcnpjtomador { get; set; }
        public int? IdCidadeTomador { get; set; }
        public string? NomeCidadeTomador { get; set; }
        public string? UfTomador { get; set; }
        public string? CodIbeCidadeTomador { get; set; }
        public int? IdCidadePrestacaoServico { get; set; }
        public string? NomeCidadePrestacaoServico { get; set; }
        public string? UfCidadePrestacaoServico { get; set; }
        public string? CodIbeCidadePrestacaoServico { get; set; }
    }
}
