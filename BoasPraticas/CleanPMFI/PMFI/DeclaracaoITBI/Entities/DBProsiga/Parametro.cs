using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Parametro
{
    public string ParamId { get; set; } = null!;

    /// <summary>
    /// Armazena o último código do Fluxo do Processo
    /// </summary>
    public long ParamIdfluxoProc { get; set; }

    /// <summary>
    /// Armazena o último código de recebimentos de processos
    /// </summary>
    public long ParamIdprocRec { get; set; }

    /// <summary>
    /// código sequencial dos recebimentos
    /// </summary>
    public long ParamIdrecebimento { get; set; }

    public long ParamIdprocesso { get; set; }

    public long ParamIdcarga { get; set; }

    public long ParamIdcontribuinte { get; set; }

    public long ParamIdferiado { get; set; }

    public long ParamIdtextoPadrao { get; set; }

    public long ParamIdanexo { get; set; }

    public long ParamIdbairro { get; set; }

    public long ParamIdcidade { get; set; }

    public long ParamIdlogProc { get; set; }

    public long ParamIdtipProc { get; set; }

    public long ParamIddoc { get; set; }

    public long ParamIdProcArq { get; set; }

    public long ParamIdos { get; set; }

    public long ParamIdmovOs { get; set; }

    public long ParamIdmanutencao { get; set; }

    public long ParamIddetalhe { get; set; }

    /// <summary>
    /// Numero sequencial para as movimentações dos bens moveis e imoveis
    /// </summary>
    public long ParamIdmovimentoMovEq { get; set; }

    public long ParamIdultBxMovEquip { get; set; }

    public decimal ParamTribProfundidadePadrao { get; set; }

    public short ParamTribAnoIptu { get; set; }

    public byte[]? ParamLogoSistema { get; set; }

    /// <summary>
    /// Código automático do modelo de bens patrimoniais. entidade &quot;Modelo&quot;
    /// </summary>
    public long ParamModId { get; set; }

    /// <summary>
    /// Codigo padrão utilizado para o calculo do Imposto Predial
    /// </summary>
    public int? ParamTipoTribIdpredial { get; set; }

    /// <summary>
    /// Codigo padrão utilizado para o calculo do Imposto Territorial
    /// </summary>
    public int? ParamTipoTribIdterritorial { get; set; }

    /// <summary>
    /// Tipo da Baixa para Isenção do Imposto qdo inferior a meia UFFI. Cfme Lei.
    /// </summary>
    public int ParamTipoBxisencaoMeiaUfm { get; set; }

    /// <summary>
    /// Tipo da Baixa para isenção dos precários com area do terreno até 500 m2.
    /// </summary>
    public int ParamTipoBxisencaoPrecarios { get; set; }

    /// <summary>
    /// Codigo de baixa para o recalculo
    /// </summary>
    public int ParamTipoBxrecalculo { get; set; }

    /// <summary>
    /// Codigo da baixa para pagamento das parcelas unicas.
    /// </summary>
    public int ParamTipoBxpagtoUnica { get; set; }

    /// <summary>
    /// Tipo da Baixa para desativar as parcelas unicas vencidas
    /// </summary>
    public int ParamTipoBxunicasVencidas { get; set; }

    /// <summary>
    /// Tipo da Baixa para os casos de Requerimento de Isencoes
    /// </summary>
    public int ParamTipoBxreqIsencao { get; set; }

    public int ParamTipoBxdeferimentoIsencao { get; set; }

    public int ParamTipoBxRevisaoDesconto { get; set; }

    public int ParamTipoBxTap { get; set; }

    public short ParamQtdeRegPorFolhaDa { get; set; }

    /// <summary>
    /// Tipo da Baixa para Dividas Transferidas
    /// </summary>
    public int ParamTipoBxDivTransferida { get; set; }

    /// <summary>
    /// ID da Baixa para as empresas isentas de taxas
    /// </summary>
    public int ParamTipoBxIsencaoTaxasEmpresa { get; set; }

    /// <summary>
    /// Tipo de baixa para usadao quando o enquadramento de MICRO-EMPRESA da 100% de desconto em uma determinada taxa.
    /// </summary>
    public int ParamTipoBxenquadramento { get; set; }
}
