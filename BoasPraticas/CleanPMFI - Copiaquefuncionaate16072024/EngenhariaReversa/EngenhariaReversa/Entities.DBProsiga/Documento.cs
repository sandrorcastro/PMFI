using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Documento
    {
        public Documento()
        {
            AlmEntrada = new HashSet<AlmEntrada>();
            FissAtividadesDoctos = new HashSet<FissAtividadesDocto>();
            FissDoctosAnexosEmpresas = new HashSet<FissDoctosAnexosEmpresa>();
            DocProTipos = new HashSet<TipoProcesso>();
        }

        public int DocId { get; set; }
        public string? DocNome { get; set; }
        public string? DocOriginal { get; set; }
        /// <summary>
        /// Observações gerais sobre o documento tal como se é recomendado se a cópia deve ser autenticada ou não.
        /// </summary>
        public string? DocObservacao { get; set; }

        public virtual ICollection<AlmEntrada> AlmEntrada { get; set; }
        public virtual ICollection<FissAtividadesDocto> FissAtividadesDoctos { get; set; }
        public virtual ICollection<FissDoctosAnexosEmpresa> FissDoctosAnexosEmpresas { get; set; }

        public virtual ICollection<TipoProcesso> DocProTipos { get; set; }
    }
}
