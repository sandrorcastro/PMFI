using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SerIturAtrativosTuristico
    {
        public SerIturAtrativosTuristico()
        {
            SerIturAtrativosServicosEquipamentos = new HashSet<SerIturAtrativosServicosEquipamento>();
            SerIturContribAtrativosTuristicos = new HashSet<SerIturContribAtrativosTuristico>();
            SerIturObjetoAtrativosTuristicos = new HashSet<SerIturObjetoAtrativosTuristico>();
            SeriTurMovAtendimentos = new HashSet<SeriTurMovAtendimento>();
            DadoEstatisticos = new HashSet<SerIturObjetoDadosEstatistico>();
            DataHists = new HashSet<SerIturDatasHistorica>();
            Destinos = new HashSet<SerIturDestino>();
        }

        public long AtrativoId { get; set; }
        public string? AtrativoLogradouro { get; set; }
        public string? AtrativoNumLograd { get; set; }
        public int? BairroId { get; set; }
        public int CidadeId { get; set; }
        public string? AtrativoNome { get; set; }
        public string? AtrativoDescricao { get; set; }
        public string? AtrativoObservacao { get; set; }
        public string? AtrativoHomePage { get; set; }
        public string? AtrativoEmail { get; set; }
        public string? AtrativoTelefone { get; set; }

        public virtual Bairro? Bairro { get; set; }
        public virtual Cidade Cidade { get; set; } = null!;
        public virtual ICollection<SerIturAtrativosServicosEquipamento> SerIturAtrativosServicosEquipamentos { get; set; }
        public virtual ICollection<SerIturContribAtrativosTuristico> SerIturContribAtrativosTuristicos { get; set; }
        public virtual ICollection<SerIturObjetoAtrativosTuristico> SerIturObjetoAtrativosTuristicos { get; set; }
        public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; }

        public virtual ICollection<SerIturObjetoDadosEstatistico> DadoEstatisticos { get; set; }
        public virtual ICollection<SerIturDatasHistorica> DataHists { get; set; }
        public virtual ICollection<SerIturDestino> Destinos { get; set; }
    }
}
