using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            //Id = Guid.NewGuid();
            
            CreateDate = DateTime.Now;
            LastUpdate = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; }

        public DateTime LastUpdate { get; set; }
}
}
