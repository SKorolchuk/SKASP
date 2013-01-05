using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
    public class ForumThemeRepository : IForumThemeRepository
    {
        public IQueryable<EntitiesModel.Theme> Themes
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<EntitiesModel.Theme> Get()
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.Theme Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(EntitiesModel.Theme Task)
        {
            throw new NotImplementedException();
        }

        public EntitiesModel.Theme Put(EntitiesModel.Theme Task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
