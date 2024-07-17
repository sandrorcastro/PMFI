using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribSisObraLoteAlvaraMovimento
    {
        public int IdalvaraMov { get; set; }
        public int? IdloteAlvara { get; set; }
        public int? IdDocumento { get; set; }
        public string? FlSituacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? EnderecoIp { get; set; }
        public int? Idmensagem { get; set; }

        public virtual TribSisObraLoteAlvara? IdloteAlvaraNavigation { get; set; }
        public virtual TribSisObraTabelaMensagem? IdmensagemNavigation { get; set; }
    }
}
