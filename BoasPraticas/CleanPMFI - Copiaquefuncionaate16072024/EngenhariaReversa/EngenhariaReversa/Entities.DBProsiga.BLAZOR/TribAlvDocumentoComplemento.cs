using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAlvDocumentoComplemento
    {
        public int IdDocumento { get; set; }
        public string? NmObra { get; set; }
        public string? TpResponsavelObra { get; set; }
        public string StCepobra { get; set; } = null!;
        public int IdLogradouroObra { get; set; }
        public int IdBairroObra { get; set; }
        public int IdCidadeObra { get; set; }
        public string StNumeroEndObra { get; set; } = null!;
        public string? StComplementoEndObra { get; set; }
        public string? StTelefoneObra { get; set; }
        public string? StEmailObra { get; set; }
        public int IdContribuinteProprietario { get; set; }
        public string StCepproprietario { get; set; } = null!;
        public int IdLogradouroProprietario { get; set; }
        public int IdBairroProprietario { get; set; }
        public int IdCidadeProprietario { get; set; }
        public string StNumeroEndProprietario { get; set; } = null!;
        public string? StComplementoEndProprietario { get; set; }
        public int IdContribuinteResponsavel { get; set; }
        public string StCepresponsavel { get; set; } = null!;
        public int IdLogradouroResponsavel { get; set; }
        public int IdBairroResponsavel { get; set; }
        public int IdCidadeResponsavel { get; set; }
        public string StNumeroEndResponsavel { get; set; } = null!;
        public string? StComplementoEndResponsavel { get; set; }
        public DateTime DtInicioObra { get; set; }
        public int? NrQuadra { get; set; }
        public int? NrLote { get; set; }
        public int? NrUnidades { get; set; }
        public int? NrPavimentos { get; set; }
        public string? RefAnterior { get; set; }
        public DateTime? DtFimObra { get; set; }
        public string? StUnidadeMedida { get; set; }
        public int? IdTipoResponsavelObra { get; set; }
        public short? IdTipoLogradObra { get; set; }
        public short? IdTipoLogradProp { get; set; }
        public short? IdTipoLogradResp { get; set; }

        public virtual TribAlvTipoResponsavel? IdTipoResponsavelObraNavigation { get; set; }
    }
}
