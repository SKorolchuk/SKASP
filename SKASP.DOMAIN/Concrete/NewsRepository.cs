// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewsRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The ef news repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using SKASP.DOMAIN.Abstract;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Concrete
{
    /// <summary>
    /// The ef news repository.
    /// </summary>
    public class EFNewsRepository : IManageable<News>
    {
        /// <summary>
        /// The context.
        /// </summary>
        private DatabaseEntities context = new DatabaseEntities();

	    public IEnumerable<News> Get()
	    {
		    throw new System.NotImplementedException();
	    }

	    public News Get(int id)
	    {
		    throw new System.NotImplementedException();
	    }

	    public bool Post(News value)
	    {
		    throw new System.NotImplementedException();
	    }

	    public News Put(News value)
	    {
		    throw new System.NotImplementedException();
	    }

	    public bool Delete(int id)
	    {
		    throw new System.NotImplementedException();
	    }

	    public IQueryable<News> Repository
	    {
		    get
		    {
			    throw new System.NotImplementedException();
		    }
	    }

	    public void AddValue(News record)
	    {
		    throw new System.NotImplementedException();
	    }

	    public void RemoveValue(News record)
	    {
		    throw new System.NotImplementedException();
	    }

	    public void EditValue(News record)
	    {
		    throw new System.NotImplementedException();
	    }
    }
}