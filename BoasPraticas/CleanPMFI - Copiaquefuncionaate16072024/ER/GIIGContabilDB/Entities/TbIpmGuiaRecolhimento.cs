using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbIpmGuiaRecolhimento
{
    public int IdGuiaRecolhimento { get; set; }

    public string? CdGuia { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdSalarioFamilia { get; set; }

    public int? IdAuxilioDoenca { get; set; }

    public int? IdSalarioMaternidade { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public short? NrMes { get; set; }

    public short? NrAno { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsTipoReceita { get; set; }

    public string? DsTipoPlano { get; set; }

    public string? DsObservacao { get; set; }

    public int? NrQtdeServidores { get; set; }

    public int? IdCc { get; set; }

    public decimal? VlBaseCalculo { get; set; }

    public decimal? VlDeclarado { get; set; }

    public decimal? VlPago { get; set; }

    public decimal? VlDeclaradoAlterado { get; set; }

    public string? DsLoginAutorizacao { get; set; }

    public DateTime? DtAutorizacao { get; set; }

    public string? DsLoginAnulacao { get; set; }

    public string? DsJustificativa { get; set; }

    public DateTime? DtAnulacao { get; set; }
}
