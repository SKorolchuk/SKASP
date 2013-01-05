using System;
using System.Collections.Generic;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
	public interface ITaskRepository
	{
		IEnumerable<Task> Get();
	 
		Task Get(int id);
	 
		Task Post(Task Task);
	 
		Task Put(Task Task);
	 
		bool Delete(int id);
	}
}