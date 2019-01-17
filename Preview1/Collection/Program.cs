using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listAuto = new List<Car>();
            listAuto.Add(new Car(1, 12.3, 2017, 31, 7.5));
            listAuto.Add(new Car(3, 2.3, 2015, 19, 23.5));
            listAuto.Add(new Car(25, 32.3, 2017, 13, 3.5));
            listAuto.Add(new Car(12, 14.3, 2011, 21, 5.5));
            Console.WriteLine("------ List Car ------");
            Display(listAuto);
            Console.WriteLine("------ List Car sort by Id ------");
            listAuto.Sort(new IDComparer());
            Display(listAuto);
            Console.WriteLine("------ List Car sort by base price ------");
            listAuto.Sort(new BasePriceComparer());
            Display(listAuto);
            Console.WriteLine("------ List Car sort by get price ------");
            listAuto.Sort(new GetPriceComparer());
            Display(listAuto);

            Console.ReadLine();
        }
        public static void Display(List<Car> listCar)
        {
            foreach(Car item in listCar)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
