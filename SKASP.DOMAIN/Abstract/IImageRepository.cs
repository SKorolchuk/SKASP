using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKASP.DOMAIN.Abstract
{
	using SKASP.DOMAIN.EntitiesModel;

	public interface IImageRepository
	{
		IQueryable<Picture> Pictures { get; set; } 
	}
}
