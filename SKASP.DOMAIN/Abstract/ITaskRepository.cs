using System;
using System.Collections.Generic;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
	public interface ITaskRepository<T>
	{
		IEnumerable<T> Get();
	 
		T Get(int id);
	 
		bool Post(T Task);
	 
		T Put(T Task);
	 
		bool Delete(int id);
	}
}