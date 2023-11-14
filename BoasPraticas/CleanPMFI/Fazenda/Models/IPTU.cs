using Fazenda.Controllers;
using Fazenda.Entities.DBProsiga;
using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fazenda.Models
{
    public class IPTU
    {
        private DbprosigaContext _context;
        private long edificacaoID;
        private TribEdificaco? imovel;
        private string inscricaoImobiliaria;
        private decimal areaTerreno;

        public IPTU()
        {
            
        }
        public IPTU(TribEdificaco imovel)
        {
            _context = new DbprosigaContext();
            this.imovel = imovel;
            EdificacaoID = this.imovel.EdificacaoId;
            InscricaoImobiliaria = this.imovel.InscricaoImobiliaria.ToString();
            AreaTerreno = (decimal) _context.TribTerrenos.Find(this.imovel.TerrenoId).TerrAreaTerreno;
            
        }
        [Key]
        public long IPTUID { get; set; }
        public long ID { get; set; }
       // [Display(Name = "ID")]
      //  public long EdificacaoID { get; set; }
        //[Display(Name = "Insc.Imob.")]
        public TribEdificaco? Imovel { get => imovel; set => imovel = value; }
        public string InscricaoImobiliaria { get => inscricaoImobiliaria; set => inscricaoImobiliaria = value; }
        public decimal AreaTerreno { get => areaTerreno; set => areaTerreno = value; }
        public decimal FatorCorrecaoArea { get; set; }
        public decimal TestadaTerreno { get; set; }
        public decimal ProfundidadePadrao { get; set; }
        public int LogradTestadaPrincipal { get; set; }
        public int QuadraId { get; set; }
        public long FatorKID { get; set; }
        public decimal FatorKValor { get; set; }
        public decimal FatorLocQuadra { get; set; }
        public decimal  FatorPedologia  { get; set; }
        public decimal FatorTopografia  { get; set; }
        public long EdificacaoID { get => edificacaoID; set => edificacaoID = Imovel.EdificacaoId; }


    }
}
