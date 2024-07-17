using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class CadEquipamento
    {
        public long CadEquipamentoId { get; set; }
        public string? CadEquiSetor { get; set; }
        public string? CadEquipLocal { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? TipoEquipamento { get; set; }
        public string? TipoEquipNome { get; set; }
        public string? CadEquipSerie { get; set; }
        public string? CadEquipIp { get; set; }
        public string? CadEquipOrigem { get; set; }
        public string? CadEquipTel { get; set; }
        public string? CadEquipDesc { get; set; }
    }
}
