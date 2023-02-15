using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink { AlcoholPercent= 25 };
            Drink drink2 = new Drink { AlcoholPercent= 39 };
            Dairy dairy1 = new Dairy { FatPercent= 7 };
            Dairy dairy2 = new Dairy { FatPercent= 9.8 };

            Store store = new Store();

            store.AddProduct(drink1);
            store.AddProduct(drink2);
            store.AddProduct(dairy1);
            store.AddProduct(dairy2);

            Console.WriteLine(store.AlcoholPercentLimit());
            Console.WriteLine(store.DairyProductCountLimit());

        }
    }
}
