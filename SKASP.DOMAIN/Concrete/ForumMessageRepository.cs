using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
    public class ForumMessageRepository : IForumMessageRepository
    {
        public IQueryable<EntitiesModel.Message> Messages
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<EntitiesModel.Message> Get()
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.Message Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(EntitiesModel.Message Task)
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.Message Put(EntitiesModel.Message Task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
