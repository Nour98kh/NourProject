using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Data.Infrastructure
{
    public class Disposable : IDisposable //Pattern gérer les ressources managées et non managées
    {
        private bool disposedValue;

        protected void Dispose(bool disposing) 
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //liberation de la ressource
                    DisposeCore();
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        protected virtual void DisposeCore()//virtual pour la redéfinition de cette méthode dans  classes filles
        {
            
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
         ~Disposable()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
             Dispose(false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
    }
}
