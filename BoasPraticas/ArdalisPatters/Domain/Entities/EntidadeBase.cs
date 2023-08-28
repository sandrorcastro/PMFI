using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntidadeBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();

        public virtual DateTime? CreatedAt { get; set; }

        public virtual DateTime? UpdatedAt { get; set; }
/*
        public void UpdateDate(EntityState state)
        {
            switch (state)
            {
                case EntityState.Added:
                case EntityState.Detached:
                    CreatedAt = DateTime.Now;

                    break;
                case EntityState.Modified:
                    UpdatedAt = DateTime.Now;

                    break;
            }
        }*/
    }

}
