using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class AlmoxDtempo
    {
        public int IdTempo { get; set; }
        public short? NrAno { get; set; }
        public byte? NrMes { get; set; }
        public byte? NrDia { get; set; }
    }
}
