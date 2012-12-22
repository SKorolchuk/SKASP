namespace SKASP.DOMAIN.Abstract
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    public interface INewsRepository
    {
        IQueryable<News> Updates { get; }
    }
}