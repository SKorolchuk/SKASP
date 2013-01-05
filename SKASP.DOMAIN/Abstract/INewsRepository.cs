using System.Linq;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
    public interface INewsRepository : ITaskRepository<News>
    {
        IQueryable<News> Updates { get; }
    }
}