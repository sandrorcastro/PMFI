using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Acessorio
{
    public long AcvVeiculoId { get; set; }

    public int AcvCompServId { get; set; }

    public long? VeicItemId { get; set; }

    public int? AcvEspecieId { get; set; }

    public int? AcvMarcaId { get; set; }

    public int? AcvModeloId { get; set; }

    public long? AcvFornecedorId { get; set; }

    public int? AcvModoAquisId { get; set; }

    public int? AcvRecursoFinId { get; set; }

    public string? AcvNumNotaFiscal { get; set; }

    public DateTime? AcvDataAquis { get; set; }

    public DateTime? AcvVenctoGarantia { get; set; }

    public string? AcvCorPredominante { get; set; }

    public string? AcvSerie { get; set; }

    public int? AcvQtde { get; set; }

    public decimal? AcvVlrTotal { get; set; }

    public string? AcvDescricao { get; set; }

    public byte[]? AcvImgComp { get; set; }

    public virtual ComponentesServico AcvCompServ { get; set; } = null!;

    public virtual Especie? AcvEspecie { get; set; }

    public virtual Contribuinte? AcvFornecedor { get; set; }

    public virtual Marca? AcvMarca { get; set; }

    public virtual Modelo? AcvModelo { get; set; }

    public virtual ModoAquisicao? AcvModoAquis { get; set; }

    public virtual RecursoFinanceiro? AcvRecursoFin { get; set; }

    public virtual Veiculo AcvVeiculo { get; set; } = null!;
}
