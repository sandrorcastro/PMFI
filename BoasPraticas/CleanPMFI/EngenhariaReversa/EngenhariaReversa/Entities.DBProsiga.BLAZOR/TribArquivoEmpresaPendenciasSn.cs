using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribArquivoEmpresaPendenciasSn
    {
        public long IdDetalheEventoEmpresa { get; set; }
        public long IdEventoEmpresa { get; set; }
        public int NrEvento { get; set; }
        public string NrCnpj { get; set; } = null!;
        public DateTime DtEvetno { get; set; }
        public string? NrAto { get; set; }
        public string? DsObservacao { get; set; }
        public string? NrProtocolo { get; set; }
    }
}
