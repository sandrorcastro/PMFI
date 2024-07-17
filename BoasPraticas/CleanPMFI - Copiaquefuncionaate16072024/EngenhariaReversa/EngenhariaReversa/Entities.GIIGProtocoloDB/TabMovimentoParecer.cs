using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabMovimentoParecer
    {
        public long MovParecerId { get; set; }
        public long? MoviId { get; set; }
        public string? DsParcer { get; set; }
        public DateTime? DtParecer { get; set; }
        public string? DsLogin { get; set; }
        public short? UnidId { get; set; }
        public short? FuncPrivado { get; set; }
        /// <summary>
        /// (Público, Privado)
        /// </summary>
        public string? MoviTipoAcesso { get; set; }
    }
}
