using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasTiposAlvara
    {
        public TribEmpresasTiposAlvara()
        {
            TribAtividadeTipoAlvaraTributos = new HashSet<TribAtividadeTipoAlvaraTributo>();
            TribEmpresasTipoAlvaraTributos = new HashSet<TribEmpresasTipoAlvaraTributo>();
        }

        public int TalvId { get; set; }
        public string? TalvDescricao { get; set; }
        /// <summary>
        /// Titulo que será impresso no Alvará
        /// </summary>
        public string TalvTituloAlvara { get; set; } = null!;
        /// <summary>
        /// Informa se o tipo de alvará pode ser o primeiro alvara para empresa
        /// </summary>
        public string TalvAceitaComoInicial { get; set; } = null!;
        /// <summary>
        /// Texto que será impresso no rodapé do Alvara
        /// </summary>
        public long? TextoId { get; set; }
        public string TalvRespTecnico { get; set; } = null!;
        public int? EdiId { get; set; }
        public string? TalvSecretaria { get; set; }
        public string? TalvDepartamento { get; set; }
        public string? TalvRestricoes { get; set; }

        public virtual TribEditalLanc? Edi { get; set; }
        public virtual ICollection<TribAtividadeTipoAlvaraTributo> TribAtividadeTipoAlvaraTributos { get; set; }
        public virtual ICollection<TribEmpresasTipoAlvaraTributo> TribEmpresasTipoAlvaraTributos { get; set; }
    }
}
