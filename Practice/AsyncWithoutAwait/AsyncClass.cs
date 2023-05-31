using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWithoutAwait
{
    internal class AsyncClass
    {
        internal async Task SomeMethod()
        {
            Console.WriteLine("Some method started");

             Wait();//current method continues

            Console.WriteLine("Some method end");
            
           
        }

        private async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));

            Console.WriteLine("5 seconds wait completed");
        }
    }
}
