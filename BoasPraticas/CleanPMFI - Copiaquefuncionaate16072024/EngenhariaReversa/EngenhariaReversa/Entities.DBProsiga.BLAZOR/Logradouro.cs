using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Logradouro
    {
        public Logradouro()
        {
            ProdRurPropriedades = new HashSet<ProdRurPropriedade>();
            SerIturEmpresasSemCmcs = new HashSet<SerIturEmpresasSemCmc>();
            TribAlvaraTermoDispencas = new HashSet<TribAlvaraTermoDispenca>();
            TribAmostraMercados = new HashSet<TribAmostraMercado>();
            TribCmprocessoLagrads = new HashSet<TribCmprocessoLagrad>();
            TribCmprocessos = new HashSet<TribCmprocesso>();
            TribEdificacos = new HashSet<TribEdificaco>();
            TribEmpresas = new HashSet<TribEmpresa>();
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
            TribTestadasTerrenos = new HashSet<TribTestadasTerreno>();
        }

        public int LogradId { get; set; }
        public string? LogradTipo { get; set; }
        public string? LogradNome { get; set; }

        public virtual ICollection<ProdRurPropriedade> ProdRurPropriedades { get; set; }
        public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; }
        public virtual ICollection<TribAlvaraTermoDispenca> TribAlvaraTermoDispencas { get; set; }
        public virtual ICollection<TribAmostraMercado> TribAmostraMercados { get; set; }
        public virtual ICollection<TribCmprocessoLagrad> TribCmprocessoLagrads { get; set; }
        public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; }
        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
        public virtual ICollection<TribTestadasTerreno> TribTestadasTerrenos { get; set; }
    }
}
