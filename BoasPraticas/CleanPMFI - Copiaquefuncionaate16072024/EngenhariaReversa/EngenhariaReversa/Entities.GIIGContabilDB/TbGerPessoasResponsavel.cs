using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerPessoasResponsavel
    {
        public int IdPessoaResponsavel { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdPessoaResp { get; set; }
        public string? DsCargo { get; set; }
        public string? NrRegistroProfissional { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public int? IdTipoCargo { get; set; }
        public int? IdTipoRegistro { get; set; }
        public DateTime? DtRegContrato { get; set; }
        public string? NrRegContrato { get; set; }
        public string? DsProfissao { get; set; }
    }
}
