using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvaraTermoDispenca
{
    public long AlvTermId { get; set; }

    public int? AlvTermNumero { get; set; }

    public short? AlvTermAno { get; set; }

    public DateTime? AlvTermDataInicial { get; set; }

    public DateTime? AlvTermDatafinal { get; set; }

    public string? AlvTermNumProtocolo { get; set; }

    public string? AlvTermAtividade { get; set; }

    public string? AlvTermRestricao { get; set; }

    public string? AlvTermNumeroLograd { get; set; }

    public string? AlvTermComplementoLograd { get; set; }

    public long? Conid { get; set; }

    public string? Cep { get; set; }

    public int? LogradId { get; set; }

    public int? BairroId { get; set; }

    public int? ObjetoId { get; set; }

    public int? CidadeId { get; set; }

    public DateTime? AlvTermDataInclusao { get; set; }

    public string? AlvTermUsuarioInclusao { get; set; }

    public virtual Bairro? Bairro { get; set; }

    public virtual Cidade? Cidade { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual Logradouro? Lograd { get; set; }

    public virtual TribObjeto? Objeto { get; set; }
}
