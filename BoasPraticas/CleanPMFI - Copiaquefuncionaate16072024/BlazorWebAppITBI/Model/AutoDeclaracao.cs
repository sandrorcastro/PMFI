using Domain.Entities.DBProsiga;

namespace BlazorWebAppITBI.Models
{
    public class AutoDeclaracao
    {
        public TribEdificaco? Imovel {  get; set; }
        public TribDocumentosTipo? TribDocumentosTipo { get; set; }


        public AutoDeclaracao()
        {
            Imovel = new TribEdificaco();

        }

    }
}
