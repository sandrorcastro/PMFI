using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribParamCalculo
    {
        public TribParamCalculo()
        {
            TribAlvaraConstrucaoParams = new HashSet<TribAlvaraConstrucaoParam>();
            TribDepreciacaoIdades = new HashSet<TribDepreciacaoIdade>();
            TribEdifParamCalculos = new HashSet<TribEdifParamCalculo>();
            TribIsencaoIncidencia = new HashSet<TribIsencaoIncidencium>();
            TribUtilizTributos = new HashSet<TribUtilizTributo>();
            Idplanta = new HashSet<TribTipoPlantasValore>();
        }

        public int TparamId { get; set; }
        public int ParamId { get; set; }
        public string? ParamNome { get; set; }
        public decimal? Fator { get; set; }
        public int? Pontos { get; set; }
        public string? CalculaImpostos { get; set; }
        public string? CaracId { get; set; }

        public virtual TribTipoParamCalculo Tparam { get; set; } = null!;
        public virtual ICollection<TribAlvaraConstrucaoParam> TribAlvaraConstrucaoParams { get; set; }
        public virtual ICollection<TribDepreciacaoIdade> TribDepreciacaoIdades { get; set; }
        public virtual ICollection<TribEdifParamCalculo> TribEdifParamCalculos { get; set; }
        public virtual ICollection<TribIsencaoIncidencium> TribIsencaoIncidencia { get; set; }
        public virtual ICollection<TribUtilizTributo> TribUtilizTributos { get; set; }

        public virtual ICollection<TribTipoPlantasValore> Idplanta { get; set; }
    }
}
