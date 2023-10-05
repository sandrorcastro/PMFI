using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblNf
    {
        public int Idnfseintermunicipal { get; set; }
        public int Idcontribuinte { get; set; }
        public int? Iddivida { get; set; }
        public DateTime? Dtvencimento { get; set; }
        public string? Numero { get; set; }
        public string Idservico { get; set; } = null!;
        public string Servdescricao { get; set; } = null!;
        public string PrestCnpj { get; set; } = null!;
        public string PrestNome { get; set; } = null!;
        public int PrestIdcidade { get; set; }
        public string? PrestCep { get; set; }
        public string? PrestLogr { get; set; }
        public string? PrestNumpredial { get; set; }
        public string? PrestCompl { get; set; }
        public string PrestBairro { get; set; } = null!;
        public string? CnaeSubclasse { get; set; }
        public DateTime Dtemissao { get; set; }
        public DateTime Dtcompetencia { get; set; }
        public string? Serie { get; set; }
        public decimal Vlservicos { get; set; }
        public decimal Vlissqn { get; set; }
        public decimal Pcaliquota { get; set; }
        public decimal? Vlpis { get; set; }
        public decimal? Vlcofins { get; set; }
        public decimal? Vlinss { get; set; }
        public decimal? Vlir { get; set; }
        public decimal? Vlcsll { get; set; }
        public decimal? Vliof { get; set; }
        public decimal? Vlretencoes { get; set; }
        public decimal? Vldesccond { get; set; }
        public decimal? Vldescincond { get; set; }
        public decimal? Vlbasecalc { get; set; }
        public decimal? Vltotalliquido { get; set; }
        public decimal? Vldeducoes { get; set; }
        public string? Cei { get; set; }
        public string? Art { get; set; }
        public string? TercCnpj { get; set; }
        public string? TercNome { get; set; }
        public string? TercCmc { get; set; }
        public string? RpsNumero { get; set; }
        public string? RpsSerie { get; set; }
        public string? RpsTipo { get; set; }
        public string? Outrasinf { get; set; }
        public byte Idregime { get; set; }
        public byte Idoperacao { get; set; }
        public string Stissretido { get; set; } = null!;
        public decimal Vlissqnretido { get; set; }
        public string Strecolheiss { get; set; } = null!;
        public string? Stunideco { get; set; }
        public DateTime? Dtpagamento { get; set; }
        public int Idcidadeservico { get; set; }
        public int? Idnfsarquivo { get; set; }
        public string? Stsituacao { get; set; }
    }
}
