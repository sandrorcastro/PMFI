using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEdifCartorio
    {
        public int IdedifCartorio { get; set; }
        public long? EdificacaoId { get; set; }
        public string? DsCnpjcartorio { get; set; }
        public string? DsInscricaoImobiliaria { get; set; }
        public string? DsMatricula { get; set; }
        public string? DsNumeroAto { get; set; }
        public DateTime? DtAto { get; set; }
        public decimal? DsFracaoTransmissao { get; set; }
        public string? DsTipoAto { get; set; }
        public string? DsTipoImovel { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
    }
}
