namespace SKASP.DOMAIN.Abstract
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    public interface IForumRepository
    {
         IQueryable<Message> Messages { get; }
         IQueryable<Topic> Topics { get; }
         IQueryable<Theme> Themes { get; }
    }
}