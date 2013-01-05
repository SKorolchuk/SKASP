using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        public IQueryable<EntitiesModel.MessageStorage> Messages
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<EntitiesModel.MessageStorage> Get()
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.MessageStorage Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(EntitiesModel.MessageStorage Task)
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.MessageStorage Put(EntitiesModel.MessageStorage Task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
