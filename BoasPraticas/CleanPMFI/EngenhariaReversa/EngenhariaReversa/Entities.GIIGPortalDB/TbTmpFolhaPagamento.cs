using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpFolhaPagamento
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Empresa { get; set; }
        public int? NrAno { get; set; }
        public int? NrMes { get; set; }
        public int? Matricula { get; set; }
        public long? Cpf { get; set; }
        public string? Nome { get; set; }
        public DateTime? Admissao { get; set; }
        public string? Cargo { get; set; }
        public string? Lotacao { get; set; }
        public string? Escala { get; set; }
        public long? CargaHoraria { get; set; }
        public decimal? SalarioBase { get; set; }
        public decimal? RemuneracaoBruta { get; set; }
        public decimal? Descontos { get; set; }
        public decimal? RemuneracaoLiquida { get; set; }
        public decimal? Vencimentos { get; set; }
        public decimal? VantagensPessoais { get; set; }
        public decimal? CargoComissao { get; set; }
        public decimal? Beneficios { get; set; }
        public decimal? Adicionais { get; set; }
        public decimal? Gratificacoes { get; set; }
        public decimal? VerbasVariaveis { get; set; }
        public decimal? VantagensTransitorias { get; set; }
        public decimal? Ferias { get; set; }
        public decimal? AbonoPermanencia { get; set; }
        public decimal? Decimo13Adiantamento { get; set; }
        public decimal? OutrasIndenizacoes { get; set; }
        public decimal? DescontosObrigatorios { get; set; }
        public decimal? DescontosFacultativos { get; set; }
        public decimal? Previdencia { get; set; }
        public decimal? ImpostoRenda { get; set; }
        public string? Regime { get; set; }
        public string? Situacao { get; set; }
        public DateTime? DataDispensa { get; set; }
        public string? Secretaria { get; set; }
    }
}
