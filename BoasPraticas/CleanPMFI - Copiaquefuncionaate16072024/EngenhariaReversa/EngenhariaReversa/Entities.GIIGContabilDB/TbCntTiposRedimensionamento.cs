using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposRedimensionamento
    {
        public TbCntTiposRedimensionamento()
        {
            TbCntAtosContratuaisItensLicitacaos = new HashSet<TbCntAtosContratuaisItensLicitacao>();
        }

        public short IdTipoRedimensionamento { get; set; }
        public string? DsTipoRedimensionamento { get; set; }
        public decimal? VlPercentual { get; set; }

        public virtual ICollection<TbCntAtosContratuaisItensLicitacao> TbCntAtosContratuaisItensLicitacaos { get; set; }
    }
}
