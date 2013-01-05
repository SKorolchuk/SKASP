using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
    public class ForumTopicRepository : IForumTopicRepository
    {
        public IQueryable<EntitiesModel.Topic> Updates
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<EntitiesModel.Topic> Get()
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.Topic Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(EntitiesModel.Topic Task)
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.Topic Put(EntitiesModel.Topic Task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
