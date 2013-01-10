using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKASP.DOMAIN.Abstract;

namespace SKASP.DOMAIN.Concrete
{
    public class EFForumRepository : IForumRepository
    {
		private DatabaseEntities dataContext = new DatabaseEntities();
		private UsersContext credentialContext = new UsersContext(); 
		
		public IForumMessageRepository Messages
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IForumTopicRepository Topics
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IForumThemeRepository Themes
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
