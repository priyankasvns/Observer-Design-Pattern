using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Potatoes potatoes = new Potatoes(4.69);
            
            potatoes.Attach(new Store("FreshCo store", 5.00));
            potatoes.Attach(new Store("Walmart store", 4.89));
            potatoes.Attach(new Store("Onkar Indian supermarket", 4.99));


            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                             New Notification about the price change                               ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            potatoes.CurrentPrice = 5.00;

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                             New Notification about the price change                               ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            potatoes.CurrentPrice = 6.00;

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                             New Notification about the price change                               ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            potatoes.CurrentPrice = 2.87;

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                             New Notification about the price change                               ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            potatoes.CurrentPrice = 4.55;

            
            Console.ReadLine();
        }
    }
}
