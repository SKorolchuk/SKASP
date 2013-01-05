// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFNewsRepository.cs" company="">
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
    public class EFNewsRepository : INewsRepository 
    {
        /// <summary>
        /// The context.
        /// </summary>
        private DatabaseEntities context = new DatabaseEntities();

        /// <summary>
        /// Gets the updates.
        /// </summary>
        public IQueryable<News> Updates 
        { 
            get
            {
                return this.context.News;
            }   
        }

        public IEnumerable<News> Get()
        {
            throw new System.NotImplementedException();
        }

        public News Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Post(News Task)
        {
            throw new System.NotImplementedException();
        }

        public News Put(News Task)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}