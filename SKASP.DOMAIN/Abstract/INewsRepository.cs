namespace SKASP.DOMAIN.Abstract
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    public interface INewsRepository : ITaskRepository
    {
        IQueryable<News> Updates { get; }
    }
}