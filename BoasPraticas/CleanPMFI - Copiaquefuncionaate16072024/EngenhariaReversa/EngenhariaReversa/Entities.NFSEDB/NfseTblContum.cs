using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblContum
    {
        public NfseTblContum()
        {
            NfseTblContaNota = new HashSet<NfseTblContaNota>();
            Iddeclaracaoapuracaos = new HashSet<DesifIdentificacaoDeclaracao>();
        }

        public int Idconta { get; set; }
        public int? Idempresa { get; set; }
        public decimal Vltotal { get; set; }
        public byte Numescompetencia { get; set; }
        public short Nuanocompetencia { get; set; }
        public DateTime Dtdatalcto { get; set; }
        /// <summary>
        /// Crédito / Débito
        /// </summary>
        public string? Sttipo { get; set; }
        public string? Stobservacao { get; set; }
        /// <summary>
        /// ATENÇÃO! Este atributo está temporariamente como varchar por causa de uma cagada q o Antônio fez.. mas como conversado com o Godoy, isso será corrigido mais a frente
        /// </summary>
        public string? Idusuario { get; set; }
        /// <summary>
        /// Usuário da plataforma Giig
        /// </summary>
        public string? Idusuarioadm { get; set; }
        public string Sttiporecolhimento { get; set; } = null!;
        public DateTime? Dtdatapagamento { get; set; }
        public int? Idcontaestorno { get; set; }
        public string? Sttipodeclaracao { get; set; }
        public string? Ststatus { get; set; }
        public string? Sterros { get; set; }
        public string? Stsituacao { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
        public virtual ICollection<NfseTblContaNota> NfseTblContaNota { get; set; }

        public virtual ICollection<DesifIdentificacaoDeclaracao> Iddeclaracaoapuracaos { get; set; }
    }
}
