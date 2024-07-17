using ITBI.Entities.DBProsiga;

namespace ITBI.Services
{
    public interface IContribuinteService
    {
        Task<List<Contribuinte>> GetContribuintes();
        Task<IQueryable<Contribuinte>> GetContribuintesQueryable();

        Task<Contribuinte> GetContribuinte(string? cpfcnpj);
        Task<IQueryable<Contribuinte>> GetContribuinteQueryable(string? cpfcnpj);
        Task<Contribuinte> AddContribuinte(Contribuinte contribuinte);
        Task<Contribuinte> UpdateContribuinte(Contribuinte contribuinte);
        //Task<Aluno> DeleteAluno(int id);

    }
}
