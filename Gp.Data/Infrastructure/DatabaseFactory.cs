using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DBContext dataContext = null;
        public DatabaseFactory()
        {
            dataContext = new DBContext();
        }
        DBContext IDatabaseFactory.DataContext
        {
            get
            {
                return dataContext;
            }
            set
            {

            }
        }

        protected override void DisposeCore() //libérer l'objet DBContext
        {
            if (dataContext != null)
            {
                dataContext.Dispose();
            }
        }


    }
}
