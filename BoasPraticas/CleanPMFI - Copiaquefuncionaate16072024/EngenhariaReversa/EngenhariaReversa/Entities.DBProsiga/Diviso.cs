using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Diviso
    {
        public Diviso()
        {
            CargasProcessoCargaDivisaoIdorigemNavigations = new HashSet<CargasProcesso>();
            CargasProcessoCargaDivisaos = new HashSet<CargasProcesso>();
            CombustivelSaida = new HashSet<CombustivelSaidum>();
            FluxoProcessos = new HashSet<FluxoProcesso>();
            Processos = new HashSet<Processo>();
            PubDocumentos = new HashSet<PubDocumento>();
            RhdadosFuncionais = new HashSet<RhdadosFuncionai>();
            TribFiscTiposVistoria = new HashSet<TribFiscTiposVistorium>();
            TribProtestoLotes = new HashSet<TribProtestoLote>();
            VeicSolicitacaos = new HashSet<VeicSolicitacao>();
            DivAutUsuarios = new HashSet<Usuario>();
        }

        public int DivId { get; set; }
        public string? DivNome { get; set; }
        public string? DivAtribuicao { get; set; }
        public long? DivServRespId { get; set; }
        public int? DivUnidadeId { get; set; }
        public int? DivLocalId { get; set; }
        public string? DivEmail { get; set; }
        public string? DivFone { get; set; }
        /// <summary>
        /// Sim ou Branco - Indica se a divisão foi extinta.
        /// </summary>
        public string? DivExtincao { get; set; }
        /// <summary>
        /// Data em que foi extinta a divisão.
        /// </summary>
        public DateTime? DivDtExtincao { get; set; }
        public string? DivIntegrProsiga { get; set; }
        public string? DivNomeResp { get; set; }
        public string? DivCargoResp { get; set; }

        public virtual Localizacao? DivLocal { get; set; }
        public virtual Unidade? DivUnidade { get; set; }
        public virtual ICollection<CargasProcesso> CargasProcessoCargaDivisaoIdorigemNavigations { get; set; }
        public virtual ICollection<CargasProcesso> CargasProcessoCargaDivisaos { get; set; }
        public virtual ICollection<CombustivelSaidum> CombustivelSaida { get; set; }
        public virtual ICollection<FluxoProcesso> FluxoProcessos { get; set; }
        public virtual ICollection<Processo> Processos { get; set; }
        public virtual ICollection<PubDocumento> PubDocumentos { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; }
        public virtual ICollection<TribFiscTiposVistorium> TribFiscTiposVistoria { get; set; }
        public virtual ICollection<TribProtestoLote> TribProtestoLotes { get; set; }
        public virtual ICollection<VeicSolicitacao> VeicSolicitacaos { get; set; }

        public virtual ICollection<Usuario> DivAutUsuarios { get; set; }
    }
}
