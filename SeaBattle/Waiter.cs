using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Waiter : IWaiter
    {
        public void WaitForNextStep()
        {
            Console.WriteLine("Вы готовы продолжить?");
            // и тд.
        }
    }
}
