using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribCmprocesso
{
    public long CmprocId { get; set; }

    public int? CmprocAno { get; set; }

    public string? CmprocNumero { get; set; }

    public DateTime? CmprocData { get; set; }

    public int? LogradId { get; set; }

    public decimal? CmprocExtensao { get; set; }

    public decimal? CmprocExtensaoTestada { get; set; }

    public int? CmtipoConstId { get; set; }

    public int? CmtipoPavId { get; set; }

    public decimal? CmprocValorM2 { get; set; }

    public decimal? CmprocValorTotalObra { get; set; }

    public decimal? CmprocValorPgtoPref { get; set; }

    public decimal? CmprocValorTrans { get; set; }

    public decimal? CmprocValorOutros { get; set; }

    public string? CmprocSituacao { get; set; }

    public DateTime? CmprocDataLicitacao { get; set; }

    public DateTime? CmprocDataConclusao { get; set; }

    public int? EdiId { get; set; }

    public int? CmprocQtdeParc { get; set; }

    public string? CmprocIntervaloRua { get; set; }

    public string? CmprocContaCorrente { get; set; }

    public virtual TribCmtipoConstrucao? CmtipoConst { get; set; }

    public virtual TribCmtipoPavimentacao? CmtipoPav { get; set; }

    public virtual TribEditalLanc? Edi { get; set; }

    public virtual Logradouro? Lograd { get; set; }

    public virtual ICollection<TribCmedificacaoProcesso> TribCmedificacaoProcessos { get; set; } = new List<TribCmedificacaoProcesso>();

    public virtual ICollection<TribCmprocessoLagrad> TribCmprocessoLagrads { get; set; } = new List<TribCmprocessoLagrad>();

    public virtual ICollection<TribDividasImo> ImoIddivida { get; set; } = new List<TribDividasImo>();

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();
}
