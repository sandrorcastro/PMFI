using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblContribuinte
    {
        public NfseTblContribuinte()
        {
            NfseTblContribuintesBeneficios = new HashSet<NfseTblContribuintesBeneficio>();
            NfseTblCredenciamentos = new HashSet<NfseTblCredenciamento>();
            NfseTblDeclaracaoExtravios = new HashSet<NfseTblDeclaracaoExtravio>();
            NfseTblEmpresas = new HashSet<NfseTblEmpresa>();
            NfseTblHomologacaoTomadors = new HashSet<NfseTblHomologacaoTomador>();
            NfseTblUsuarios = new HashSet<NfseTblUsuario>();
        }

        public int Idcontribuinte { get; set; }
        public string? Stnome { get; set; }
        public string? Stcpfcnpj { get; set; }
        public string? Sttipo { get; set; }
        public int? Idcidade { get; set; }
        public string? Stcep { get; set; }
        public string? StenderecoLogr { get; set; }
        public string? StenderecoNumero { get; set; }
        public string? StenderecoComplemento { get; set; }
        public string? StenderecoBairro { get; set; }
        public string? Stim { get; set; }
        public string? Stemail { get; set; }
        public string? Sttelefone { get; set; }
        public string? Stsituacao { get; set; }
        public string? Stendcorresp { get; set; }
        public string? Stnumcorresp { get; set; }
        public string? Stfax { get; set; }
        public string? Stie { get; set; }
        public string? Stii { get; set; }
        public DateTime? Dtcadastro { get; set; }
        public bool? Stobrigarecad { get; set; }
        public int? Idcidadecorresp { get; set; }
        public string? Stendcomplcorresp { get; set; }
        public string? Stendbairrocorresp { get; set; }
        public string? Stcepcorresp { get; set; }
        public int? Conid { get; set; }
        public string? Cadorigem { get; set; }

        public virtual ICollection<NfseTblContribuintesBeneficio> NfseTblContribuintesBeneficios { get; set; }
        public virtual ICollection<NfseTblCredenciamento> NfseTblCredenciamentos { get; set; }
        public virtual ICollection<NfseTblDeclaracaoExtravio> NfseTblDeclaracaoExtravios { get; set; }
        public virtual ICollection<NfseTblEmpresa> NfseTblEmpresas { get; set; }
        public virtual ICollection<NfseTblHomologacaoTomador> NfseTblHomologacaoTomadors { get; set; }
        public virtual ICollection<NfseTblUsuario> NfseTblUsuarios { get; set; }
    }
}
