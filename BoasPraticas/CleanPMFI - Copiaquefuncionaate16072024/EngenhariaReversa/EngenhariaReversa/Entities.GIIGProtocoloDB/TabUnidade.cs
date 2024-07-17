using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabUnidade
    {
        public TabUnidade()
        {
            InverseUnidhierarquiaNavigation = new HashSet<TabUnidade>();
            TabFuncionarios = new HashSet<TabFuncionario>();
            TabMovimentos = new HashSet<TabMovimento>();
            TabRoteiros = new HashSet<TabRoteiro>();
        }

        public short UnidId { get; set; }
        public string? UnidSigla { get; set; }
        public string? UnidNome { get; set; }
        public string? UnidDescricao { get; set; }
        public short? Unidhierarquia { get; set; }
        public byte? TipoUnidId { get; set; }
        public string? Cidtbxulc { get; set; }
        public string UnidFlAtivo { get; set; } = null!;

        public virtual TabUnidadeTipo? TipoUnid { get; set; }
        public virtual TabUnidade? UnidhierarquiaNavigation { get; set; }
        public virtual ICollection<TabUnidade> InverseUnidhierarquiaNavigation { get; set; }
        public virtual ICollection<TabFuncionario> TabFuncionarios { get; set; }
        public virtual ICollection<TabMovimento> TabMovimentos { get; set; }
        public virtual ICollection<TabRoteiro> TabRoteiros { get; set; }
    }
}
