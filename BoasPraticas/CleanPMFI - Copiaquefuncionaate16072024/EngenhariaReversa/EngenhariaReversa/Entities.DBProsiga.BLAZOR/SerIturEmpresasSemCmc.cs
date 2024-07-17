using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SerIturEmpresasSemCmc
    {
        public SerIturEmpresasSemCmc()
        {
            SerIturEmpresasSemCmcativs = new HashSet<SerIturEmpresasSemCmcativ>();
            SeriTurMovAtendimentos = new HashSet<SeriTurMovAtendimento>();
            SeriturPublicaEmpresas = new HashSet<SeriturPublicaEmpresa>();
        }

        public long EmprId { get; set; }
        public string? EmprNome { get; set; }
        public string? EmprCep { get; set; }
        public int? LogradId { get; set; }
        public string? EmprEnderecoNum { get; set; }
        public string? EmprComplemento { get; set; }
        public int? BairroId { get; set; }
        public int? CidadeId { get; set; }
        public string? EmprTelefone { get; set; }
        public int? EmprTipoId { get; set; }
        public short? EmprTipoEntidadeId { get; set; }
        public string? NomeResponsavel { get; set; }
        public string? CargoResponsavel { get; set; }
        public string? ConEmail { get; set; }
        public string? ConSite { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }

        public virtual Bairro? Bairro { get; set; }
        public virtual Cidade? Cidade { get; set; }
        public virtual TribEmpresasTipo? EmprTipo { get; set; }
        public virtual TribEmpresasTipoEntidade? EmprTipoEntidade { get; set; }
        public virtual Logradouro? Lograd { get; set; }
        public virtual ICollection<SerIturEmpresasSemCmcativ> SerIturEmpresasSemCmcativs { get; set; }
        public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; }
        public virtual ICollection<SeriturPublicaEmpresa> SeriturPublicaEmpresas { get; set; }
    }
}
