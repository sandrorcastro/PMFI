using Domain.Entities;

namespace Domain.Filters;

public record MegaData_NFSEFilter : BaseFilter
{
    //public DateTime DataGeracao { get; set; } = DateTime.Now.AddMonths(-1) ;
    public DateTime DataGeracao { get; set; } 
    public MegaData_NFSEFilter()
    {
        
    }
    
}
