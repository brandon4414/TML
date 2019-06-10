using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bleak;

namespace TAHT.Injection
{
    /* This section of code uses the Bleak c# injection library.
     * https://github.com/Akaion/Bleak
     * https://www.nuget.org/packages/Bleak */

    internal class InjectDLL
    {
        private Injector i;

        public void Inject(string dllPath, string processName, bool randomize)
        {
            i = new Injector(InjectionMethod.CreateThread, dllPath, processName, randomize);
            var baseAddr = i.InjectDll();
            i.HideDllFromPeb();
        }

        public void GTFO()
        {
            i.EjectDll();
            i.Dispose();
        }
    }
}