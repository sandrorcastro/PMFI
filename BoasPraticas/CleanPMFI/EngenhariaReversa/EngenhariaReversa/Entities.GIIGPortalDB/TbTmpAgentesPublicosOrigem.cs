using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpAgentesPublicosOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal? Adicional { get; set; }
        public decimal? Beneficio { get; set; }
        public long? CargaHoraria { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DataAlocacao { get; set; }
        public DateTime? DataDispensa { get; set; }
        public decimal? DecimoTerceiro { get; set; }
        public int? EncargoEspecial { get; set; }
        public decimal? Ferias { get; set; }
        public decimal? Gratificacao { get; set; }
        public int? HorasExtras { get; set; }
        public decimal? Irrf { get; set; }
        public string? LocalLotacao { get; set; }
        public int? Matricula { get; set; }
        public string? Nome { get; set; }
        public decimal? OutrasVantagens { get; set; }
        public decimal? OutrosDescontos { get; set; }
        public decimal? Previdencia { get; set; }
        public decimal? Remuneracao { get; set; }
        public decimal? RemuneracaoTotal { get; set; }
        public string? Situacao { get; set; }
        public string? VinculoEmpregaticio { get; set; }
    }
}
