using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribSisObraLoteAlvara
    {
        public TribSisObraLoteAlvara()
        {
            TribSisObraLoteAlvaraAlvDocumentos = new HashSet<TribSisObraLoteAlvaraAlvDocumento>();
            TribSisObraLoteAlvaraMovimentos = new HashSet<TribSisObraLoteAlvaraMovimento>();
        }

        public int IdloteAlvara { get; set; }
        public int? Numero { get; set; }
        public int? Ano { get; set; }
        public string? FlSituacao { get; set; }
        public string? DsTipoDocumento { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public byte[]? DsXml { get; set; }

        public virtual ICollection<TribSisObraLoteAlvaraAlvDocumento> TribSisObraLoteAlvaraAlvDocumentos { get; set; }
        public virtual ICollection<TribSisObraLoteAlvaraMovimento> TribSisObraLoteAlvaraMovimentos { get; set; }
    }
}
