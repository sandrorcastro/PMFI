﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribRegistrosGrafica2018DemaisParc
    {
        public string InscricaoImobiliaria { get; set; } = null!;
        public string? Responsavel { get; set; }
        public string? ConTipoLograd { get; set; }
        public string? ConCep { get; set; }
        public string? ConEndereco { get; set; }
        public string? ConNumero { get; set; }
        public string? ConComplemento { get; set; }
        public string? BaiNome { get; set; }
        public string? CidNome { get; set; }
        public string? CidUf { get; set; }
        public int TemDescontoCombInc { get; set; }
        public int TemIsencaoMinhaCasa { get; set; }
        public long? Ordem { get; set; }
        public int? TotalDividas { get; set; }
    }
}
