

using System.Collections;
using System.Collections.Generic;

namespace MVC.Models
{
    public interface IPaginatedList:IList
    {
        int? CurrentPage { get; }
        int? TotalPages { get; }
        int? TotalItems { get;  }
        bool HasPrevious { get; }
        bool HasNext { get; }
    }
}
