using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TribCadastrofInscrico
    {
        public long EdificacaoId { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public int? IdRegiao { get; set; }
        public int? IdLoteamento { get; set; }
        public string? DsCaracteristica { get; set; }
        public string? DsSituacao { get; set; }
        public int? IdCategoria { get; set; }
        public decimal? VlAreaTerreno { get; set; }
        public decimal? VlAreaConstruida { get; set; }
        public string? DsResponsavel { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int IdPimovelRural { get; set; }
        public int IdPtipoConstrucao { get; set; }
        public int IdPutilizacao { get; set; }
        public int IdPuso { get; set; }
        public int IdPposicao { get; set; }
        public int IdPagrupamento { get; set; }
        public int IdPestrutura { get; set; }
        public int IdPacabamentoInterno { get; set; }
        public int IdPacabamentoExterno { get; set; }
        public int IdPinstalacaoEletrica { get; set; }
        public int IdPpiso { get; set; }
        public int IdPcobertura { get; set; }
        public int IdPsituacao { get; set; }
        public int IdPforro { get; set; }
        public int IdPocupacaoEdificacao { get; set; }
        public int IdPparede { get; set; }
        public int IdPesquadrias { get; set; }
        public int IdPestadoConservacao { get; set; }
        public int IdPincidenciaEdificacao { get; set; }
        public int IdPpatrimonio { get; set; }
        public int IdPocupacaoTerreno { get; set; }
        public int IdPlocalizacao { get; set; }
        public int IdPtopografia { get; set; }
        public int IdPcondicao { get; set; }
        public int IdPfundoVale { get; set; }
        public int IdPpedologia { get; set; }
        public int IdPincidenciaTerreno { get; set; }
        public int IdPvegetacao { get; set; }
        public int IdPlimiteTestada { get; set; }
        public int IdPcalcada { get; set; }
        public int IdPcondominioResid { get; set; }
        public string? DsPossuiDividaPendente { get; set; }
        public string? DsPossuiDividaSuspensa { get; set; }
    }
}
