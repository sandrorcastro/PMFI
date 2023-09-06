using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TribParamClassificacaoReceitum
    {
        public int ClassId { get; set; }
        public int? TipoTribId { get; set; }
        public int TipoDivId { get; set; }
        public short? ClassDe { get; set; }
        public short? ClassAte { get; set; }
        public string? ClassReceitaVlrPrincipal { get; set; }
        public string? ClassReceitaVlrCorrecao { get; set; }
        public string? ClassReceitaVlrJuros { get; set; }
        public string? ClassReceitaVlrMulta { get; set; }
        public string? ClassReceitaVlrMultaDa { get; set; }
        public string? ClassReceitaVlrDevolucao { get; set; }
        public string? ClassReceitaVlrRenuncia { get; set; }
        public string? ClassReceitaVlrDesconto { get; set; }
        public string? ClassReceitaVlrOutrasDeducoes { get; set; }
    }
}
