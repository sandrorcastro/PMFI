using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbcelepardebitosdividaativa
    {
        public int Iddividaativa { get; set; }
        public short Tipodocumento { get; set; }
        public long Numdocumento { get; set; }
        public string Nomedevedor { get; set; } = null!;
        public DateTime Dtinscricaoda { get; set; }
        public string Autoformatado { get; set; } = null!;
        public decimal Vlrnotificadodivida { get; set; }
        public DateTime Dtvencimento { get; set; }
        public int Idintegracaomunicipio { get; set; }
        public DateTime Dtinfracao { get; set; }
        public decimal? Vlrpagamento { get; set; }
        public DateTime? Dtbaixapagamento { get; set; }
        public DateTime? Dtinclusao { get; set; }
        public int? Idusuarioinclusao { get; set; }
        /// <summary>
        /// ID do contribuinte que foi integrado a divida.
        /// </summary>
        public long? Conidintegrado { get; set; }
        public long? Coniddividaintegrado { get; set; }
        /// <summary>
        /// Indica se o contribuinte foi criado pela integração (Novo = S)
        /// </summary>
        public string? Flconidnovo { get; set; }
    }
}
