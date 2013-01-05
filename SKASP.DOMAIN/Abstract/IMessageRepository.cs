namespace SKASP.DOMAIN.Abstract
{
    using System.Linq;

    using SKASP.DOMAIN.EntitiesModel;

    public interface IMessageRepository : ITaskRepository<MessageStorage>
    {
        IQueryable<MessageStorage> Messages { get; }
    }
}