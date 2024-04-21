using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEdificacoesLancamentosAnteriore
    {
        public string InscricaoImobiliaria { get; set; } = null!;
        public string? Proprietario { get; set; }
        public decimal Valor2013 { get; set; }
        public decimal Valor2012 { get; set; }
        public decimal Valor2011 { get; set; }
        public decimal Valor2010 { get; set; }
        public decimal Valor2009 { get; set; }
        public decimal Valor2008 { get; set; }
        public decimal Valor2007 { get; set; }
        public decimal Valor2006 { get; set; }
        public decimal Valor2005 { get; set; }
        public decimal Valor2004 { get; set; }
        public decimal Valor2003 { get; set; }
    }
}
