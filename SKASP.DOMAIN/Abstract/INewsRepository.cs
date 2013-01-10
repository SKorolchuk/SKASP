using System.Linq;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
    public interface INewsRepository : ITaskRepository<News>, IManageable<T>
    {
        IQueryable<News> Updates { get; }
	    void AddNews(News record);
	    void RemoveNews(News record);
	    void EditNews(News record);
    }
}