using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbIpmSeguradoFolha
    {
        public int IdSegurado { get; set; }
        public int? IdPessoa { get; set; }
        public short? DsCategoria { get; set; }
        public string? CdMatricula { get; set; }
        public string? IdCargo { get; set; }
        public short? IdOrgao { get; set; }
        public DateTime? DtAdmissao { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtExclusao { get; set; }
        public string? IdFonte { get; set; }
        public string? Excluido { get; set; }
        public string? DsMotivoExclusao { get; set; }
        public short? DsSituacao { get; set; }
        public DateTime? DtSituacao { get; set; }
    }
}
