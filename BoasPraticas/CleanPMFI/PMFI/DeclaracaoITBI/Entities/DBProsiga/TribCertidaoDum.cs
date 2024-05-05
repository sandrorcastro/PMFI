using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCertidaoDum
{
    public long CertidaoDaid { get; set; }

    public int? CertidaoDanumero { get; set; }

    public int? CertidaoDaano { get; set; }

    public DateTime? CertidaoDadata { get; set; }

    /// <summary>
    /// Marca a situação da inscrição na certidão Normal ou Cancelada para casos de extorno da divida da certidão.
    /// </summary>
    public string CertidaoDasituacao { get; set; } = null!;

    public long? LivroDaid { get; set; }

    /// <summary>
    /// Texto da certidão.
    /// </summary>
    public long? TextoId { get; set; }

    /// <summary>
    /// Data que a certidão foi encaminhada ao forum para processo de ajuizamento.
    /// </summary>
    public DateTime? CertidaoDadataAjuizamento { get; set; }

    /// <summary>
    /// Número do processo no forum.
    /// </summary>
    public string? CertidaoDanumProcesso { get; set; }

    /// <summary>
    /// Vara Cível que o processo foi protocolado. ex. 1º Vara, 2º Vara e etc...
    /// </summary>
    public string? CertidaoDavaraCivel { get; set; }

    /// <summary>
    /// Observações sobre o ajuizamento.
    /// </summary>
    public string? CertidaoDaobsAjuizamento { get; set; }

    /// <summary>
    /// Usuário que incluiu a baixa
    /// </summary>
    public string? Usuario { get; set; }

    /// <summary>
    /// Nome da maquina que fez a baixa.
    /// </summary>
    public string? Host { get; set; }

    public DateTime? DataInclusao { get; set; }

    public int? ObjetoId { get; set; }

    public int? CertidaoDanumeroCancelamento { get; set; }

    public int? CertidaoDaanoCancelamento { get; set; }

    public int? CertidaoDatextoIdcancelamento { get; set; }

    public DateTime? CertidaoDadataCancelamento { get; set; }

    public string? DsTexto { get; set; }

    public string? DsTextoSuperior { get; set; }

    public string? DsTitulo { get; set; }

    public virtual TribLivroDividaAtiva? LivroDa { get; set; }

    public virtual TribTexto? Texto { get; set; }

    public virtual ICollection<TribCertidaoDalivro> TribCertidaoDalivros { get; set; } = new List<TribCertidaoDalivro>();

    public virtual ICollection<TribCertidaoDaversao> TribCertidaoDaversaos { get; set; } = new List<TribCertidaoDaversao>();

    public virtual ICollection<TribHonorariosCdum> TribHonorariosCda { get; set; } = new List<TribHonorariosCdum>();

    public virtual ICollection<TribProcPeticaoCertidao> TribProcPeticaoCertidaos { get; set; } = new List<TribProcPeticaoCertidao>();

    public virtual ICollection<TribProtestoLoteCdum> TribProtestoLoteCda { get; set; } = new List<TribProtestoLoteCdum>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();

    public virtual ICollection<Servidore> Servs { get; set; } = new List<Servidore>();
}
