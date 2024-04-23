using ITBI.Entities.DBProsiga;

namespace ITBI.Services
{
    public interface IImovelService
    {
        Task<List<TribEdificaco>> GetImoveis();
        Task<IQueryable<TribEdificaco>> GetImoveisQueryable();

        Task<TribEdificaco> GetImovel(string? inscricaoimobiliaria);
        Task<IQueryable<TribEdificaco>> GetImovelQueryable(string? inscricaoimobiliaria);
        //Task<IQueryable<TribEdificaco>> GetImovelQueryable();


        //  Task<TribEdificaco> AddContribuinte(TribEdificaco contribuinte);
        //Task<TribEdificaco> UpdateContribuinte(TribEdificaco contribuinte);
        //Task<Aluno> DeleteAluno(int id);

    }
}
