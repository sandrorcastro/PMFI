using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaPerfil
    {
        public int Idperfil { get; set; }
        public int? Idempresa { get; set; }
        public string? Stnomefantasia { get; set; }
        public string? Stsite { get; set; }
        public string? Stresume { get; set; }
        public string? StcontatoNome { get; set; }
        public string? StcontatoTelefone { get; set; }
        public string? StcontatoEmail { get; set; }
        public string? Stemail { get; set; }
        public string? Stfraseseguranca { get; set; }
        public byte[]? Imlogo { get; set; }
        public string? StautorizaContadorRps { get; set; }
        public string? Strazaosocial { get; set; }
        public string? Stincentivadorcultural { get; set; }
        public string? Sttipoempresa { get; set; }
        public string? Stobservacoes { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
    }
}
