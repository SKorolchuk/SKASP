// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFNewsRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The ef news repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SKASP.DOMAIN.Concrete
{
    using System.Linq;

    using SKASP.DOMAIN.Abstract;
    using SKASP.DOMAIN.EntitiesModel;

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
    }
}