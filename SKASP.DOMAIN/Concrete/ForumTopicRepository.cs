using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
	using System.Diagnostics;

	using SKASP.DOMAIN.EntitiesModel;

	public class ForumTopicRepository : IManageable<Topic>
    {
		private DatabaseEntities dataContext = new DatabaseEntities();

		public IEnumerable<Topic> Get()
		{
			return dataContext.Topics;
		}

		public Topic Get(int id)
		{
			return dataContext.Topics.FirstOrDefault(x => x.ID == id);
		}

		public bool Post(Topic value)
		{
			try
			{
				this.AddValue(value);
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}
		}

		public Topic Put(Topic value)
		{
			try
			{
				this.EditValue(value);
				return value;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return null;
			}
		}

		public bool Delete(int id)
		{
			try
			{
				dataContext.Topics.Remove(dataContext.Topics.FirstOrDefault(x => x.ID == id));
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}
		}

		public IQueryable<Topic> Repository 
		{ 
			get
			{
				return dataContext.Topics;
			} 
		}

		public void AddValue(Topic record)
		{
			if (dataContext.Topics.Count(x => x.ID == record.ID) == 0)
			{
				dataContext.Topics.Add(record);
				dataContext.SaveChanges();
			}
		}

		public void RemoveValue(Topic record)
		{
			if (dataContext.Topics.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Topics.Remove(record);
			}
		}

		public void EditValue(Topic record)
		{
			if (this.dataContext.Messages.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Topics.Remove(dataContext.Topics.FirstOrDefault(x => x.ID == record.ID));
				dataContext.Topics.Add(record);
				dataContext.SaveChanges();
			}
		}
    }
}
