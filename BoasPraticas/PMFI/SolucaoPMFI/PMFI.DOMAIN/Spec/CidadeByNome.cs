using Ardalis.Specification;
using PMFI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFI.Domain.Spec
{
    public class CidadeByNomeSpec : Specification<Cidade>
    {
        public CidadeByNomeSpec(string nome)
        {
            Query.Where(c => c.Nome == nome);
        }
    }
}
