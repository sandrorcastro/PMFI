using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbNavPerguntasFrequente
    {
        public int IdPerguntaFrequente { get; set; }
        public int? NrPergunta { get; set; }
        public string? DsPergunta { get; set; }
        public string? DsResposta { get; set; }
        public int? IdGrupoPerguntaFrequente { get; set; }

        public virtual TbNavGrupoPerguntasFrequente? IdGrupoPerguntaFrequenteNavigation { get; set; }
    }
}
