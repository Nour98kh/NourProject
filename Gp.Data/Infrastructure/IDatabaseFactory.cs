using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DBContext DataContext {get; set;} 
    }
}
