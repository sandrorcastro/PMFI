using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAinfarquivo
    {
        public TribAinfarquivo()
        {
            TribAinfarquivoDetalhes = new HashSet<TribAinfarquivoDetalhe>();
            TribAinfarquivoDividasLancada = new HashSet<TribAinfarquivoDividasLancada>();
        }

        public int IdAinfarquivo { get; set; }
        public int? VersaoLeiaute { get; set; }
        public DateTime? DataGeracao { get; set; }
        public string? NomeArquivo { get; set; }
        public string? Filler { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioInclusao { get; set; } = null!;

        public virtual ICollection<TribAinfarquivoDetalhe> TribAinfarquivoDetalhes { get; set; }
        public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; }
    }
}
