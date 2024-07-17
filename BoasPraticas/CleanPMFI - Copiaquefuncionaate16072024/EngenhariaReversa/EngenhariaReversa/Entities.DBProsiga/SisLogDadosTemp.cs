using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SisLogDadosTemp
    {
        public string? Campo { get; set; }
        public string? ValorNovo { get; set; }
        public string? ValorAntigo { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Data { get; set; }
        public int? Codigo { get; set; }
        public long? EdificacaoId { get; set; }
        public string? InscricaoImobiliaria { get; set; }
    }
}
