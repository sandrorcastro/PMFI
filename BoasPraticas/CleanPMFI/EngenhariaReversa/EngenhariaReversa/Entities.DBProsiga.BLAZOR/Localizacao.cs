using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Localizacao
    {
        public Localizacao()
        {
            Divisos = new HashSet<Diviso>();
            EdumovimentoLotacaos = new HashSet<EdumovimentoLotacao>();
            Eduturmas = new HashSet<Eduturma>();
            LocSubLocals = new HashSet<LocSubLocal>();
            LocalFisicos = new HashSet<LocalFisico>();
            RhcargoFuncaoLocals = new HashSet<RhcargoFuncaoLocal>();
            RhdadosFuncionaiLocIdatuacaoNavigations = new HashSet<RhdadosFuncionai>();
            RhdadosFuncionaiLocIdlotacaoNavigations = new HashSet<RhdadosFuncionai>();
            SocPasses = new HashSet<SocPasse>();
            TribEditalCompras = new HashSet<TribEditalCompra>();
        }

        public int LocId { get; set; }
        public string? LocNome { get; set; }
        public string? LocFone { get; set; }
        public string? LocCep { get; set; }
        public string? LocEndereco { get; set; }
        public string? LocNumero { get; set; }
        public string? LocComplemento { get; set; }
        public string? LocBairro { get; set; }
        public string? LocCidade { get; set; }
        public string? LocUf { get; set; }
        public string? LocRespMatricula { get; set; }
        public string? LocRespNome { get; set; }
        public long? TipoLocId { get; set; }

        public virtual EdutipoLocal? TipoLoc { get; set; }
        public virtual ICollection<Diviso> Divisos { get; set; }
        public virtual ICollection<EdumovimentoLotacao> EdumovimentoLotacaos { get; set; }
        public virtual ICollection<Eduturma> Eduturmas { get; set; }
        public virtual ICollection<LocSubLocal> LocSubLocals { get; set; }
        public virtual ICollection<LocalFisico> LocalFisicos { get; set; }
        public virtual ICollection<RhcargoFuncaoLocal> RhcargoFuncaoLocals { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiLocIdatuacaoNavigations { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiLocIdlotacaoNavigations { get; set; }
        public virtual ICollection<SocPasse> SocPasses { get; set; }
        public virtual ICollection<TribEditalCompra> TribEditalCompras { get; set; }
    }
}
