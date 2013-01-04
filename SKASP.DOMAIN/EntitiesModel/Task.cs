using System;
using System.Collections.Generic;

namespace SKASP.DOMAIN.EntitiesModel
{
    public class Task
	{
		public int Id { get; set; }
	 
		public string Description { get; set; }
	 
		public int Priority { get; set; }
	 
		public DateTime CreatedOn { get; set; }
	}
}