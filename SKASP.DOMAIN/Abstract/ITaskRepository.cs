using System;
using System.Collections.Generic;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
	public interface ITaskRepository<T>
	{
		IEnumerable<T> Get();
	 
		T Get(int id);
	 
		bool Post(T value);
	 
		T Put(T value);
	 
		bool Delete(int id);
	}
}