namespace SKASP.DOMAIN.Abstract
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    public interface IForumRepository
    {
         IForumMessageRepository Messages { get; set; }
         IForumTopicRepository Topics { get; set; }
         IForumThemeRepository Themes { get; set; }
    }
}