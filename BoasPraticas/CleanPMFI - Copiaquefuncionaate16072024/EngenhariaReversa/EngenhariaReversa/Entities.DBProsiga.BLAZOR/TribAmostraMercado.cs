using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAmostraMercado
    {
        public TribAmostraMercado()
        {
            TribAmostraMercadoItbis = new HashSet<TribAmostraMercadoItbi>();
        }

        public int AmostraId { get; set; }
        public string? AmostraTipo { get; set; }
        public string? AmostraCondominio { get; set; }
        public int Idloteamento { get; set; }
        public int LogradId { get; set; }
        public string? AmostraNumero { get; set; }
        public decimal? AmostraAreaTerreno { get; set; }
        public decimal? AmostraAreaConstruida { get; set; }
        public decimal? AmostraValor { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }

        public virtual Loteamento IdloteamentoNavigation { get; set; } = null!;
        public virtual Logradouro Lograd { get; set; } = null!;
        public virtual ICollection<TribAmostraMercadoItbi> TribAmostraMercadoItbis { get; set; }
    }
}
