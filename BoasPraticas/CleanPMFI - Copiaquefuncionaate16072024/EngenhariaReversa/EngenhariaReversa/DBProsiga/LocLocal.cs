using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class LocLocal
    {
        public int LocalId { get; set; }
        public string? LocNomeLocal { get; set; }
        public string? LocFone { get; set; }
        public string? LocRespMatricula { get; set; }
        public string? LocRespNome { get; set; }
        public string? LocRespRg { get; set; }
        public string? LocCep { get; set; }
        public string? LocTipoLogr { get; set; }
        public string? LocNomeLogr { get; set; }
        public int? LocNumPredial { get; set; }
        public string? LocBairro { get; set; }
        public string? LocTecUltAlt { get; set; }
        public string? LocHostUltAlt { get; set; }
        public DateTime? LocDtUltAlt { get; set; }
    }
}
