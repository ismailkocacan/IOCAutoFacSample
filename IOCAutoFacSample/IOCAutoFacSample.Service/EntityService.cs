using IOCAutoFacSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCAutoFacSample.Service
{
    public interface IEntityService
    {
        IList<Entity> GetList();
    }

    public class EntityService : IEntityService
    {
        public IList<Entity> GetList()
        {
            return new List<Entity>()
            {
                new Entity(){Id = 1,Name = "Entity 1"},
                new Entity(){Id = 1,Name = "Entity 2"},
                new Entity(){Id = 1,Name = "Entity 3"}
            };
        }
    }
}
