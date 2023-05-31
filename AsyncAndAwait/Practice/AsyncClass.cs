using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class AsyncClass
    {
        internal async void SomeMethod()
        {
            Console.WriteLine("Some method started");

            await Task.Delay(TimeSpan.FromSeconds(1));// wait for this operation before running the next line of the code

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Some method end");
            }
           
        }
    }
}
