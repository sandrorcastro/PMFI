using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TempLivroDividaAtiva
    {
        public long LivroDaid { get; set; }
        public int? LivroDafolha { get; set; }
        public int? LivroDaseq { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public long? LivroDanumero { get; set; }
        public DateTime? LivroDadataInscricao { get; set; }
        public decimal? LivroDamultaDa { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string LivroDasituacao { get; set; } = null!;
        public short? LivroDaanoTermo { get; set; }
        public int? LivroDanumeroTermo { get; set; }
        public string? LivroDamotivo { get; set; }
        public DateTime? LivroDadataCancelamento { get; set; }
        public string? LivroDausuarioCancelamento { get; set; }
    }
}
