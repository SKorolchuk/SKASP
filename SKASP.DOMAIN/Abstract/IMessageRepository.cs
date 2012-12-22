namespace SKASP.DOMAIN.Abstract
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    public interface IMessageRepository
    {
        IQueryable<MessageStorage> Messages { get; }
    }
}