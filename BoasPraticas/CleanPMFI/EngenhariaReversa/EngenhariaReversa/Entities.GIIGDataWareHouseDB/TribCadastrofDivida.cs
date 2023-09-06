using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribCadastrofDivida
    {
        public long EdificacaoId { get; set; }
        public int? NrAno { get; set; }
        public int IdGrupoTributo { get; set; }
        public int IdTipoTributo { get; set; }
        public int IdTipoBaixa { get; set; }
        public int IdTipoDivida { get; set; }
        public decimal? VlValorDivida { get; set; }
    }
}
