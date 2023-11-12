using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

/// <summary>
/// Cadastro e Manutenção de Tipos de Credenciamento
/// </summary>
public partial class FztipoCredenciamento
{
    /// <summary>
    /// Código de Identificação do Tipo de Credenciamento
    /// </summary>
    public int CredenTipoId { get; set; }

    /// <summary>
    /// Descrição do Nome do Tipo de Credenciamento. Podem ser por Empresa [SocioProprietario-Empregado-Turnante] e por Veículo[Permissionario-Colaborador-Auxiliar].
    /// </summary>
    public string CredenTipoNome { get; set; } = null!;

    public int? Idtipoveiculo { get; set; }

    public int? Idtipocurso { get; set; }

    public bool? Flexigeseguro { get; set; }

    public int? Flvenctocredencial { get; set; }

    public string? Flsubtipo { get; set; }

    public bool? Flvinculoveiculo { get; set; }

    public bool? Flvinculoponto { get; set; }

    public bool? Fldeprecated { get; set; }

    public bool? Flexigevistoria { get; set; }

    public bool? Flexigenrveiculo { get; set; }

    /// <summary>
    /// Define se o tipo da Credencial Exige Curso 0-Não Exige Curso para liberacao Credencial. Códigos 1a 5 de Tipo Credencial não utilizados atualmente.
    /// </summary>
    public int? ExigeCursoCodigo { get; set; }

    public int? TmpCredTipoAnterior { get; set; }

    public string? CredenSigla { get; set; }

    public int CredentialTipoAnterior { get; set; }

    public string CredencialNomeAnterior { get; set; } = null!;

    public virtual ICollection<FzcredencialAncient> FzcredencialAncients { get; set; } = new List<FzcredencialAncient>();

    public virtual ICollection<Fzcredencial> Fzcredencials { get; set; } = new List<Fzcredencial>();

    public virtual ICollection<FzcredenciamentoAte201103> FzcredenciamentoAte201103s { get; set; } = new List<FzcredenciamentoAte201103>();
}
