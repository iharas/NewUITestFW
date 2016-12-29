using System;
using System.Threading;
using OpenQA.Selenium;

namespace NewUITestFW.DriverControl
{
    public interface IWebDriverSource : IDisposable
    {
        IWebDriver Driver { get; set; }
    }

    public class SharedThreadLocalDriverSource : IWebDriverSource
    {
        readonly ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>();

        public IWebDriver Driver
        {
            get { return _driver.Value; }
            set { _driver.Value = value; }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    foreach (IWebDriver local in this._driver.Values)
                    {
                        local.Quit();
                    }
                    /* TODO: is this.driver - managed or not managed? :D
                     * TODO: Do we actually need this code? Maybe the following will be enouth:
                    this.driver.Dispose()
                     */
                }
            }
        }

        public static SharedThreadLocalDriverSource Instance = new SharedThreadLocalDriverSource();

        private bool _disposedValue = false; //to check redundant calls

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~SDriver() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }

}