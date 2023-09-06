using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegPerfisdeAcessoFormulario
    {
        public short IdPerfilAcesso { get; set; }
        public short IdForm { get; set; }
        public bool? FlInclusao { get; set; }
        public bool? FlAlteracao { get; set; }
        public bool? FlRemocao { get; set; }
        public bool? FlPermEspeciais { get; set; }

        public virtual TbSegFormulario IdFormNavigation { get; set; } = null!;
        public virtual TbSegPerfisdeAcesso IdPerfilAcessoNavigation { get; set; } = null!;
    }
}
