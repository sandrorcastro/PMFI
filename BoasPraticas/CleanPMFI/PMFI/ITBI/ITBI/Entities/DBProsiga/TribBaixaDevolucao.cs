using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribBaixaDevolucao
{
    public long BaDeId { get; set; }

    /// <summary>
    /// Código de Identificação do Processo
    /// </summary>
    public long? ProcId { get; set; }

    public DateTime? BaDeDataDevolucao { get; set; }

    public string? BaDeMotivo { get; set; }

    /// <summary>
    /// Valor deve ser atualizado por trigger na entidade tribBaixaDevolucaoDividas
    /// </summary>
    public decimal BaDeValor { get; set; }

    public long? ConId { get; set; }

    public long? ConvenioId { get; set; }

    public string? BaDeSituacao { get; set; }

    public string? BaDeUsuario { get; set; }

    public DateTime? BaDeDataInclusao { get; set; }

    public DateTime? BaDeDataBaixa { get; set; }

    public string? BaDeUsuarioBaixa { get; set; }

    public int? IdDespesa { get; set; }

    public int? NrDespesa { get; set; }

    public int? NrAnoDespesa { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual ICollection<TribBaixaDevolucaoCompensacao> TribBaixaDevolucaoCompensacaos { get; set; } = new List<TribBaixaDevolucaoCompensacao>();

    public virtual ICollection<TribBaixaDevolucaoDivida> TribBaixaDevolucaoDivida { get; set; } = new List<TribBaixaDevolucaoDivida>();
}
