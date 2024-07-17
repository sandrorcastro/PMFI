using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Bairro
    {
        public Bairro()
        {
            Contribuintes = new HashSet<Contribuinte>();
            ProdRurPropriedades = new HashSet<ProdRurPropriedade>();
            SerIturAtrativosTuristicos = new HashSet<SerIturAtrativosTuristico>();
            SerIturEmpresasSemCmcs = new HashSet<SerIturEmpresasSemCmc>();
            TribAlvaraTermoDispencas = new HashSet<TribAlvaraTermoDispenca>();
            TribEmpresas = new HashSet<TribEmpresa>();
        }

        public int BairroId { get; set; }
        public string? BaiNome { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? Host { get; set; }
        public long? Idregiao { get; set; }

        public virtual ICollection<Contribuinte> Contribuintes { get; set; }
        public virtual ICollection<ProdRurPropriedade> ProdRurPropriedades { get; set; }
        public virtual ICollection<SerIturAtrativosTuristico> SerIturAtrativosTuristicos { get; set; }
        public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; }
        public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
    }
}
