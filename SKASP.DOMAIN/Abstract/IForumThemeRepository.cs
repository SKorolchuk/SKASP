using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.EntitiesModel;

namespace SKASP.DOMAIN.Abstract
{
    public interface IForumThemeRepository : ITaskRepository<Theme>
    {
        IQueryable<Theme> Themes { get; } 
    }
}
