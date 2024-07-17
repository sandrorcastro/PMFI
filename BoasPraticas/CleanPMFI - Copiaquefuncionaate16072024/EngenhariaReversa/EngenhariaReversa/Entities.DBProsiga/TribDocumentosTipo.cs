﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribDocumentosTipo
    {
        public TribDocumentosTipo()
        {
            TribDocumentos = new HashSet<TribDocumento>();
        }

        public int IdTipoDoc { get; set; }
        public string? NmTipoDoc { get; set; }
        public string? DsTipoDoc { get; set; }
        public long? TextoId { get; set; }

        public virtual TribTexto? Texto { get; set; }
        public virtual ICollection<TribDocumento> TribDocumentos { get; set; }
    }
}
