namespace BlazorWebAppITBI.Models
{
    public class ValoresOperacao
    {
        public decimal ValorDeclarado { get; set; }
        public decimal? ValorFinanciado { get; set; }
        public decimal? ValorRecursoProprio { get; set; }
        public bool isFinanciado { get; set; } = false;
        public bool isento { get; set; } = false;

        public string? Financimanto { get; set; }
        public  decimal aliquotafinanciamento { get; set; }
        public string ValorImpostoDevido { get; set; }
        public int tipotribid {  get; set; }
        public int tipoBxId { get; set; }

       
    }
}
