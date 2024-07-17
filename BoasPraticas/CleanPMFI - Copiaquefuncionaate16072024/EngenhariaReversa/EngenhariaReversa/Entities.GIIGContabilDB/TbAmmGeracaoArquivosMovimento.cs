using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbAmmGeracaoArquivosMovimento
    {
        public int IdGeracao { get; set; }
        public int IdObjeto { get; set; }
        public string? NmObjeto { get; set; }
    }
}
