using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEdificacoesLancamentosDeducao
    {
        public string InscricaoImobiliaria { get; set; } = null!;
        public string? Proprietario { get; set; }
        public decimal Valor2013 { get; set; }
        public decimal Valor2012 { get; set; }
        public decimal Valor2011 { get; set; }
        public decimal Valor2010 { get; set; }
        public decimal Valor2009 { get; set; }
        public decimal Valor2008 { get; set; }
    }
}
