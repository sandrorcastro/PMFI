using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class TbNavGrupoPerguntasFrequente
    {
        public TbNavGrupoPerguntasFrequente()
        {
            TbNavPerguntasFrequentes = new HashSet<TbNavPerguntasFrequente>();
        }

        public int IdGrupoPerguntaFrequente { get; set; }
        public string? DsGrupoPerguntaFrequente { get; set; }
        public int? NrOrdem { get; set; }
        public short? IdEmpresa { get; set; }
        public short? IdSistema { get; set; }

        public virtual ICollection<TbNavPerguntasFrequente> TbNavPerguntasFrequentes { get; set; }
    }
}
