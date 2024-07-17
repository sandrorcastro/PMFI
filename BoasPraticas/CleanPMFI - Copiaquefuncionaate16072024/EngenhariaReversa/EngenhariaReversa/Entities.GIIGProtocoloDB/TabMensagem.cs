using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabMensagem
    {
        public TabMensagem()
        {
            TabMensagemDestinos = new HashSet<TabMensagemDestino>();
            Anes = new HashSet<TabAnexo1>();
        }

        public long MensId { get; set; }
        public string? MensTitulo { get; set; }
        public string? MensMensagem { get; set; }
        public short? FuncId { get; set; }
        public string? MensStatus { get; set; }
        public DateTime? MensData { get; set; }
        public string? MensFiltroDestino { get; set; }

        public virtual TabFuncionario? Func { get; set; }
        public virtual ICollection<TabMensagemDestino> TabMensagemDestinos { get; set; }

        public virtual ICollection<TabAnexo1> Anes { get; set; }
    }
}
