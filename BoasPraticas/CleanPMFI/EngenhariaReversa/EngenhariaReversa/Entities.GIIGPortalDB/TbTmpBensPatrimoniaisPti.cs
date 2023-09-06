using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpBensPatrimoniaisPti
    {
        public int? Id { get; set; }
        public string? CentroCusto { get; set; }
        public DateTime? DataAquisicao { get; set; }
        public string? Descricao { get; set; }
        public string? Orgao { get; set; }
        public int? Placa { get; set; }
        public string? Responsavel { get; set; }
        public string? Situacao { get; set; }
        public string? TipoAquisicao { get; set; }
        public string? TipoNatureza { get; set; }
        public decimal? ValorAquisicao { get; set; }
    }
}
