using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Cidade
    {
        public Cidade()
        {
            Contribuintes = new HashSet<Contribuinte>();
            ProdRurPropriedades = new HashSet<ProdRurPropriedade>();
            Regios = new HashSet<Regio>();
            SaudePacienteXxxxxxes = new HashSet<SaudePacienteXxxxxx>();
            SerIturAtrativosTuristicos = new HashSet<SerIturAtrativosTuristico>();
            SerIturEmpresasSemCmcs = new HashSet<SerIturEmpresasSemCmc>();
            TribAlvaraTermoDispencas = new HashSet<TribAlvaraTermoDispenca>();
            TribEmpresas = new HashSet<TribEmpresa>();
        }

        public int CidadeId { get; set; }
        public string? CidNome { get; set; }
        public string? CidUf { get; set; }
        /// <summary>
        /// Código Estadual do Fundo Municipal de Participação
        /// </summary>
        public string? CidFmp { get; set; }
        public int? PaisId { get; set; }
        public int? CdIbge { get; set; }

        public virtual Paise? Pais { get; set; }
        public virtual ICollection<Contribuinte> Contribuintes { get; set; }
        public virtual ICollection<ProdRurPropriedade> ProdRurPropriedades { get; set; }
        public virtual ICollection<Regio> Regios { get; set; }
        public virtual ICollection<SaudePacienteXxxxxx> SaudePacienteXxxxxxes { get; set; }
        public virtual ICollection<SerIturAtrativosTuristico> SerIturAtrativosTuristicos { get; set; }
        public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; }
        public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
    }
}
