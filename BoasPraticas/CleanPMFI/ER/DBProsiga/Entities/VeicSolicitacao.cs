using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VeicSolicitacao
{
    public int VeicSolicId { get; set; }

    public DateTime? DtSolicIni { get; set; }

    public DateTime? DtSolicFim { get; set; }

    /// <summary>
    /// Servidor que efetivamente utilizará o veículo, 
    /// </summary>
    public string? ServSolicitante { get; set; }

    /// <summary>
    /// Divisão que está solicitando o veículo, a fim de resolver problemas do tipo usuario da div A, solicita carro para a divisão B
    /// </summary>
    public int? DivId { get; set; }

    /// <summary>
    /// Tipo do Veiculo-Tem o objetivo de definir se usuario precisa de um caminhão, uma kombi ou um veiculo de passeio-ver se isso pode ser resolvido na especie
    /// </summary>
    public int? EspecieId { get; set; }

    public string? DescrUtilizacao { get; set; }

    public string? DescrRecusa { get; set; }

    /// <summary>
    /// Aguardando,Reservado, Negado
    /// </summary>
    public string? VeicStatus { get; set; }

    /// <summary>
    /// Servidor que esta efetuando a solicitação de veículo
    /// </summary>
    public long? ServId { get; set; }

    public DateTime? DtCadastro { get; set; }

    public long? ServAtendimentoId { get; set; }

    /// <summary>
    /// Data que a Solicitacao foi atendida
    /// </summary>
    public DateTime? DtAtendimento { get; set; }

    public virtual Diviso? Div { get; set; }

    public virtual Especie? Especie { get; set; }

    public virtual Servidore? Serv { get; set; }

    public virtual ICollection<XFrotaOrdensServico> XFrotaOrdensServicos { get; set; } = new List<XFrotaOrdensServico>();
}
