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

	public class ForumThemeRepository : IManageable<Theme>
    {
		private DatabaseEntities dataContext = new DatabaseEntities();

		public IQueryable<Theme> Repository
		{
			get
			{
				return dataContext.Themes;
			}
		}

		public IEnumerable<Theme> Get()
		{
			return Repository;
		}

		public Theme Get(int id)
		{
			return Repository.FirstOrDefault(x => x.ID == id);
		}

		public bool Post(Theme value)
		{
			try
			{
				this.AddValue(value);
				return true;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}
		}

		public Theme Put(Theme value)
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
				this.RemoveValue(Repository.FirstOrDefault(x => x.ID == id));
				return true;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}
		}

		public void AddValue(Theme record)
		{
			if (dataContext.Themes.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Themes.Add(record);
				dataContext.SaveChanges();
			}
		}

		public void RemoveValue(Theme record)
		{
			if (this.dataContext.Themes.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Themes.Remove(record);
				dataContext.SaveChanges();
			}
		}

		public void EditValue(Theme record)
		{
			if (this.dataContext.Themes.Count(x => x.ID == record.ID) > 0)
			{
				dataContext.Themes.Remove(dataContext.Themes.FirstOrDefault(x => x.ID == record.ID));
				dataContext.Themes.Add(record);
				dataContext.SaveChanges();
			}
		}
    }
}
