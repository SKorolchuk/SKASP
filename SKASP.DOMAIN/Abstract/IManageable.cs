using System.Linq;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
    public interface IManageable<T> : ITaskRepository<T>
    {
        IQueryable<T> Repository { get; }
	    void AddValue(T record);
	    void RemoveValue(T record);
	    void EditValue(T record);
    }
}