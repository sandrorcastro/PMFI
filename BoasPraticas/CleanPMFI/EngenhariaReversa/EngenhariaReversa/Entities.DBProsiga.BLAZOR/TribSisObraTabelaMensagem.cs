using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribSisObraTabelaMensagem
    {
        public TribSisObraTabelaMensagem()
        {
            TribSisObraLoteAlvaraMovimentos = new HashSet<TribSisObraLoteAlvaraMovimento>();
        }

        public int Idmensagem { get; set; }
        public string? Codigo { get; set; }
        public string? Descricao { get; set; }

        public virtual ICollection<TribSisObraLoteAlvaraMovimento> TribSisObraLoteAlvaraMovimentos { get; set; }
    }
}
