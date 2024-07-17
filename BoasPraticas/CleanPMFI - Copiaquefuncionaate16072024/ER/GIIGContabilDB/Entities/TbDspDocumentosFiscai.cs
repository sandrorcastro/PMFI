using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspDocumentosFiscai
{
    public int IdDoctoFiscal { get; set; }

    public short? IdEmpresa { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdTipoDoctoFiscal { get; set; }

    public string? NrDocumento { get; set; }

    public DateTime? DtDocumento { get; set; }

    public decimal? VlDocumento { get; set; }

    public DateTime? DtVencimento { get; set; }

    public short? IdTipoSerieDocFiscal { get; set; }

    public int? IdDotacao { get; set; }

    public int? IdNatDespesa { get; set; }

    public string? DsHistorico { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtRecebimento { get; set; }

    public int? NrSequenciaAnual { get; set; }

    public short? NrAno { get; set; }

    public virtual TbDspTiposDocumentosFiscai? IdTipoDoctoFiscalNavigation { get; set; }

    public virtual TbDspTiposSerieDocFiscal? IdTipoSerieDocFiscalNavigation { get; set; }

    public virtual ICollection<TbDspDocumentosFiscaisIten> TbDspDocumentosFiscaisItens { get; set; } = new List<TbDspDocumentosFiscaisIten>();

    public virtual ICollection<TbDspEmpenho> IdEmpenhos { get; set; } = new List<TbDspEmpenho>();
}
