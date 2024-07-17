using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifIdentificacaoDeclaracao
    {
        public DesifIdentificacaoDeclaracao()
        {
            Idconta = new HashSet<NfseTblContum>();
        }

        public int Iddeclaracao { get; set; }
        public string Stcnpj { get; set; } = null!;
        public string Stnome { get; set; } = null!;
        public string Idtipoinstituicao { get; set; } = null!;
        public int? Idcidade { get; set; }
        public string Stanomesinicomp { get; set; } = null!;
        public string Stanomesfimcomp { get; set; } = null!;
        public byte Numodulodec { get; set; }
        public byte Nutipodec { get; set; }
        public int? Nuprotdec { get; set; }
        public byte? Nutipoconsolida { get; set; }
        public string? Stcnpjresprecolhe { get; set; }
        public string Idversao { get; set; } = null!;
        public byte? Nutipoarredonda { get; set; }
        public DateTime Dtemissao { get; set; }
        public int? Idempresa { get; set; }

        public virtual ICollection<NfseTblContum> Idconta { get; set; }
    }
}
