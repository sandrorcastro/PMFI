using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    /// <summary>
    /// Leitura dos Hidrometros
    /// </summary>
    public partial class AguaLeituraHidrometro
    {
        public AguaLeituraHidrometro()
        {
            AguaDividasLeituras = new HashSet<AguaDividasLeitura>();
            AguaDividasServAguas = new HashSet<AguaDividasServAgua>();
        }

        /// <summary>
        /// Identificação exclusiva da leitura
        /// 
        /// </summary>
        public long LeituraId { get; set; }
        /// <summary>
        /// Código de Identificação do Hidrômetro
        /// </summary>
        public int? HidroId { get; set; }
        /// <summary>
        /// Valor da ultima leitura
        /// </summary>
        public decimal? LeituraAnterior { get; set; }
        /// <summary>
        /// Valor lido na atualidade
        /// 
        /// </summary>
        public decimal? LeituraAtual { get; set; }
        /// <summary>
        /// Data da leitura
        /// 
        /// </summary>
        public DateTime? LeituraData { get; set; }
        public short? LeituraMes { get; set; }
        public int? LeituraAno { get; set; }
        /// <summary>
        /// ATIVA ou CANCELADA
        /// </summary>
        public string? LeituraSituacao { get; set; }
        /// <summary>
        /// Histórico do lançamento
        /// 
        /// </summary>
        public string? LeituraHistorico { get; set; }
        /// <summary>
        /// Data do cancelamento, quando a situação for cancelada
        /// 
        /// </summary>
        public DateTime? LeituraDataCancel { get; set; }
        /// <summary>
        /// Usuário/técnico responsável pela leitura
        /// 
        /// </summary>
        public string? LeituraUsuarioLeitura { get; set; }
        /// <summary>
        /// Usuário que realizou lançamento da leitura
        /// 
        /// </summary>
        public string? LeituraUsuarioLancamento { get; set; }
        /// <summary>
        /// Usuário que executou o lançamento de cancelamento
        /// 
        /// </summary>
        public string? LeituraUsuarioCancel { get; set; }
        public int? LeituraZeroHidrometro { get; set; }

        public virtual AguaHidrometro? Hidro { get; set; }
        public virtual ICollection<AguaDividasLeitura> AguaDividasLeituras { get; set; }
        public virtual ICollection<AguaDividasServAgua> AguaDividasServAguas { get; set; }
    }
}
