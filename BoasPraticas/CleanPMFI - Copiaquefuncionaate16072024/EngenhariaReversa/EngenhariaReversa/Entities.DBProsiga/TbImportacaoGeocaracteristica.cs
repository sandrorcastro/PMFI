using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbImportacaoGeocaracteristica
    {
        public int IdImportacaoGeocaracteristica { get; set; }
        public int IdImportacaoGeo { get; set; }
        public int Tid { get; set; }
        public string? Tnome { get; set; }
        public int? Vid { get; set; }
        public string? Vnome { get; set; }
        public string? Valor { get; set; }
    }
}
