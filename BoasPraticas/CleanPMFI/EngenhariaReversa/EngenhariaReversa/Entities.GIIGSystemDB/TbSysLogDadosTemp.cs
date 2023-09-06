using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSysLogDadosTemp
    {
        public long IdLoDa { get; set; }
        public string? NmBanco { get; set; }
        public string? NmTabela { get; set; }
        public string? DsTabelaAlias { get; set; }
        public string? DsOperacao { get; set; }
        public string? DsObjetoOcorrencia { get; set; }
        public DateTime? DtOcorrencia { get; set; }
        public string? DsLogin { get; set; }
        public string? DsEnderecoIp { get; set; }
    }
}
