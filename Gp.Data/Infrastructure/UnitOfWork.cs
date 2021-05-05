using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        IDatabaseFactory Factory;
        public UnitOfWork(IDatabaseFactory Factory)
        {
            this.Factory = Factory;
        }
        public void Commit()
        {
            Factory.DataContext.SaveChanges();
        }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(Factory);
        }
        public void Dispose()
        {
            Factory.Dispose();
        }
    }
}
