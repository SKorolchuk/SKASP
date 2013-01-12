using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
    public class MessageRepository : IManageable<MessageRepository>
    {
	    public IEnumerable<MessageRepository> Get()
	    {
		    throw new NotImplementedException();
	    }

	    public MessageRepository Get(int id)
	    {
		    throw new NotImplementedException();
	    }

	    public bool Post(MessageRepository value)
	    {
		    throw new NotImplementedException();
	    }

	    public MessageRepository Put(MessageRepository value)
	    {
		    throw new NotImplementedException();
	    }

	    public bool Delete(int id)
	    {
		    throw new NotImplementedException();
	    }

	    public IQueryable<MessageRepository> Repository
	    {
		    get
		    {
			    throw new NotImplementedException();
		    }
	    }

	    public void AddValue(MessageRepository record)
	    {
		    throw new NotImplementedException();
	    }

	    public void RemoveValue(MessageRepository record)
	    {
		    throw new NotImplementedException();
	    }

	    public void EditValue(MessageRepository record)
	    {
		    throw new NotImplementedException();
	    }
    }
}
