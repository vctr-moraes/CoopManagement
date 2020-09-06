using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models
{
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
