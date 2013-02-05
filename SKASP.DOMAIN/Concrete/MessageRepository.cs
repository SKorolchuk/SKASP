using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
	using SKASP.DOMAIN.EntitiesModel;

	public class MessageRepository : IManageable<MessageStorage>
	{
		private DatabaseEntities dataContext = new DatabaseEntities();

		public IQueryable<MessageStorage> Repository
		{
			get { return dataContext.MessageStorages; }
		}

		public void AddValue(MessageStorage record)
		{
			if (this.dataContext.MessageStorages.Count(x => x.ID == record.ID) == 0)
			{
				dataContext.MessageStorages.Add(record);
				dataContext.SaveChanges();
			}
		}

		public void RemoveValue(MessageStorage record)
		{
			if (this.dataContext.MessageStorages.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.MessageStorages.Remove(dataContext.MessageStorages.FirstOrDefault(x => x.ID == record.ID));
				dataContext.SaveChanges();
			}
		}

		public void EditValue(MessageStorage record)
		{
			if (this.dataContext.MessageStorages.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.MessageStorages.Remove(dataContext.MessageStorages.FirstOrDefault(x => x.ID == record.ID));
				dataContext.MessageStorages.Add(record);
				dataContext.SaveChanges();
			}
		}

		public IEnumerable<MessageStorage> Get()
		{
			throw new NotImplementedException();
		}

		public MessageStorage Get(int id)
		{
			throw new NotImplementedException();
		}

		public bool Post(MessageStorage value)
		{
			throw new NotImplementedException();
		}

		public MessageStorage Put(MessageStorage value)
		{
			throw new NotImplementedException();
		}

		public bool Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
