namespace BlazorWebAppITBI.Models
{
    public class ValoresOperacao
    {
        public decimal ValorDeclarado { get; set; }
        public decimal? ValorFinanciado { get; set; }
        public decimal? ValorRecursoProprio { get; set; }
        public bool isFinanciado { get; set; } = false;

        public string? Financimanto { get; set; }
       
    }
}
