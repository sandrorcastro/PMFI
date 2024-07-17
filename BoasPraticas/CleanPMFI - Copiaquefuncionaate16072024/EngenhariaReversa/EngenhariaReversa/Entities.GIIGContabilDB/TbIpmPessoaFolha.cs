using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbIpmPessoaFolha
    {
        public int IdPessoa { get; set; }
        public string? NmPessoa { get; set; }
        public string? FlSexo { get; set; }
        public string? DsLogradouro { get; set; }
        public string? DsBairro { get; set; }
        public string? NrCep { get; set; }
        public string? DsEmail { get; set; }
        public string? NrFoneResidencial { get; set; }
        public string? NrFoneComercial { get; set; }
        public string? NrFoneCelular { get; set; }
        public string? DtNascimento { get; set; }
        public string? DsCidade { get; set; }
        public string? DsUf { get; set; }
        public string? NmPai { get; set; }
        public string? NmMae { get; set; }
        public short? DsEstadoCivil { get; set; }
        public string? NrCpf { get; set; }
        public string? NrRg { get; set; }
        public string? NrPis { get; set; }
        public string? NrTitulo { get; set; }
        public string? NrSecao { get; set; }
        public string? NrZona { get; set; }
        public string? DsNaturalidade { get; set; }
        public string? DsUfnatural { get; set; }
        public string? NrCtps { get; set; }
        public string? DsOrgaoExpedidorRg { get; set; }
        public string? DtEmissaoRg { get; set; }
        public string? NrSerieCtps { get; set; }
        public string? DsUfctps { get; set; }
        public string? DtEmissaoCtps { get; set; }
        public string? NrPredial { get; set; }
        public string? DsLocalExpedidorCtps { get; set; }
    }
}
