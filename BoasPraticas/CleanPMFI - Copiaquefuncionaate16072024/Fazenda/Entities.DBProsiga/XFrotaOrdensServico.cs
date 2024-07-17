using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class XFrotaOrdensServico
{
    public long XFosnum { get; set; }

    public long? XFosidVeiculo { get; set; }

    public DateTime? XFosdataIni { get; set; }

    public DateTime? XFosdataFim { get; set; }

    public int? XFoskmInicial { get; set; }

    /// <summary>
    /// campo totalizador
    /// </summary>
    public int? XFoskmfinal { get; set; }

    public int? XFoskms { get; set; }

    public int? VeicSolicId { get; set; }

    /// <summary>
    /// Servidor que efetuou ultima alteração ou que esta atendendo a solicitação de veiculos
    /// </summary>
    public long? ServId { get; set; }

    /// <summary>
    /// Data da Ultima Alteração da Ordem de Serviço
    /// </summary>
    public DateTime? XFosdtUltAlt { get; set; }

    public virtual Servidore? Serv { get; set; }

    public virtual VeicSolicitacao? VeicSolic { get; set; }

    public virtual Veiculo? XFosidVeiculoNavigation { get; set; }

    public virtual ICollection<XFrotaMovOrdensServico> XFrotaMovOrdensServicos { get; set; } = new List<XFrotaMovOrdensServico>();
}
