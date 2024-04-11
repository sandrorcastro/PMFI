using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Membro
{
    public string MemCnpj { get; set; } = null!;

    public string? MemRazaoSocial { get; set; }

    public string? MemNomeFantasia { get; set; }

    public string? MemNomePrefeito { get; set; }

    public string? MemCargoPrefeito { get; set; }

    public byte[]? MemImgLogo { get; set; }

    public string? MemFone { get; set; }

    public byte[]? MemImgLogo2 { get; set; }

    public string? MemCep { get; set; }

    public string? MemTipoLograd { get; set; }

    public string? MemEndereco { get; set; }

    public string? MemEndNum { get; set; }

    public string? MemComplEnd { get; set; }

    public string? MemBairro { get; set; }

    public string? MemCidade { get; set; }

    public string? MemUf { get; set; }

    public string? MemEmail { get; set; }

    public string? MemSite { get; set; }

    public int? MemCodDivisao { get; set; }

    public string? MemTrabalhaSab { get; set; }

    public string? MemTrabalhaDom { get; set; }

    /// <summary>
    /// Código da moeda, para geração dos boletos.
    /// </summary>
    public string? MemCodMoeda { get; set; }

    /// <summary>
    /// Numero de vias do Comprovante de entrada no Módulo PROSIGA
    /// </summary>
    public short MemNumViasComprovante { get; set; }

    public string MemProcUtilizaAnoNum { get; set; } = null!;

    public string? MemSigla { get; set; }

    public virtual ICollection<Imovei> Imoveis { get; set; } = new List<Imovei>();

    public virtual ICollection<MembrosUsuario> MembrosUsuarios { get; set; } = new List<MembrosUsuario>();

    public virtual ICollection<Orgao> Orgaos { get; set; } = new List<Orgao>();

    public virtual ICollection<RhdadosPessoai> RhdadosPessoais { get; set; } = new List<RhdadosPessoai>();
}
