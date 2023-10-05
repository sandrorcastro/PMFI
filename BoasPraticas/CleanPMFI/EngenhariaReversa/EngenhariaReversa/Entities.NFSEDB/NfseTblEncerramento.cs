using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEncerramento
    {
        public NfseTblEncerramento()
        {
            NfseTblEncerramentoBoletos = new HashSet<NfseTblEncerramentoBoleto>();
        }

        public int Idencerramento { get; set; }
        public DateTime Dtlancamento { get; set; }
        public byte Numescompetencia { get; set; }
        public short Nuanocompetencia { get; set; }
        public int? Idempresa { get; set; }
        public string Idusuario { get; set; } = null!;
        public int? Iddivida { get; set; }
        public DateTime? Dtvencimento { get; set; }
        public string? Stsituacao { get; set; }
        public int? Idtipotributo { get; set; }
        public string? Idtipobaixa { get; set; }
        public string? Sttipodivida { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
        public virtual ICollection<NfseTblEncerramentoBoleto> NfseTblEncerramentoBoletos { get; set; }
    }
}
