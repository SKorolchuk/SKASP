using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
	using SKASP.DOMAIN.EntitiesModel;

	public class ForumMessageRepository : IManageable<Message>
	{
		private DatabaseEntities dataContext = new DatabaseEntities();

		public IQueryable<Message> Repository
		{
			get { return dataContext.Messages; }
		}

		public void AddValue(Message record)
		{
			if (this.dataContext.Messages.Count(x => x.ID == record.ID) == 0)
			{
				dataContext.Messages.Add(record);
				dataContext.SaveChanges();
			}
		}

		public void RemoveValue(Message record)
		{
			if (this.dataContext.Messages.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Messages.Remove(record);
				dataContext.SaveChanges();
			}
		}

		public void EditValue(Message record)
		{
			if (this.dataContext.Messages.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Messages.Remove(dataContext.Messages.FirstOrDefault(x => x.ID == record.ID));
				dataContext.Messages.Add(record);
				dataContext.SaveChanges();
			}
		}

		public IEnumerable<Message> Get()
		{
			throw new NotImplementedException();
		}

		public Message Get(int id)
		{
			throw new NotImplementedException();
		}

		public bool Post(Message value)
		{
			throw new NotImplementedException();
		}

		public Message Put(Message value)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
