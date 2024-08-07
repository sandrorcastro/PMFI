﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbImoInvasao
    {
        public TbImoInvasao()
        {
            TbDadosDaReintegracaos = new HashSet<TbDadosDaReintegracao>();
        }

        public int IdInvasao { get; set; }
        public DateTime DtInvasao { get; set; }
        public decimal? AreaAcupadaInvasao { get; set; }
        public string? NmLoteInvasao { get; set; }
        public string? ObsInvasao { get; set; }
        public string ImoCnpjfilial { get; set; } = null!;
        public string ImoInscricao { get; set; } = null!;
        public DateTime DtUsoCapiao { get; set; }

        public virtual ImobensImovei Imo { get; set; } = null!;
        public virtual ICollection<TbDadosDaReintegracao> TbDadosDaReintegracaos { get; set; }
    }
}
