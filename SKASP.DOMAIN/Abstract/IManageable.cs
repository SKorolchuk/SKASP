using System.Linq;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
    public interface IManageable<T>
    {
        IQueryable<T> repository { get; }
	    void AddValue(T record);
	    void RemoveValue(T record);
	    void EditValue(T record);
    }
}