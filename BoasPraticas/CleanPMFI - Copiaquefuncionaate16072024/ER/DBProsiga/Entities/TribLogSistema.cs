using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribLogSistema
{
    public long LogId { get; set; }

    public long? EdificacaoId { get; set; }

    public long? EmprCmc { get; set; }

    public long? ConId { get; set; }

    /// <summary>
    /// Gravar o número da inscrição imobiliária sempre que gravar EdificacaoID, CNPJ ou CPF sempre que for Empresa ou Contribuinte.
    /// </summary>
    public string? CnpjCpfInscricao { get; set; }

    public string? LoSiTipoOcorrencia { get; set; }

    public string? LoSiOcorrencia { get; set; }

    public string? LoSiUsuario { get; set; }

    public string? LoSiHost { get; set; }

    public DateTime? LoSiData { get; set; }
}
