using System;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Struct str = new Struct(1, 12.4, 2018, 234, 23.1);
            Car car = new Car(1, 13.4, 2016, 13, 9.5);

            Console.WriteLine(str.ToString());
            Console.WriteLine(car.ToString());

            Console.WriteLine("=======");

            Auto[] listAuto = new Auto[100];
            int index = 0;
            while (true)
            {
                int choice = 0;
                Menu();
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    int id, year = 2016, numOfPass;
                    double basePrice, pricePerPass =7.9;
                    try
                    {
                        Console.Write("Enter ID:");
                        id = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < index; i++)
                        {
                            if(id == listAuto[i].id)
                            {
                                throw new DuplicateException("ID is exist");
                            }
                        }
                        Console.Write("Enter Number of Passenger:");
                        numOfPass = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter base price:");
                        basePrice = Convert.ToDouble(Console.ReadLine());
                        if(basePrice < 0)
                        {
                            throw new PositiveException("Base price must be > 0", basePrice);
                        }
                        listAuto[index] = new Car(id, basePrice, year, numOfPass, pricePerPass);
                        index++;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(DuplicateException exDp)
                    {
                        Console.WriteLine(exDp.Message);
                    }
                    catch(PositiveException exP)
                    {
                        Console.WriteLine(exP.Message);
                        Console.WriteLine("Current base price: " + exP.basePrice);
                    }
                }
                if(choice == 2)
                {
                    int id, year = 2016, weight = 23;
                    double basePrice, addedPrice = 3.9;
                    try
                    {
                        Console.Write("Enter ID:");
                        id = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < index; i++)
                        {
                            if (id == listAuto[i].id)
                            {
                                throw new DuplicateException("ID is exist");
                            }
                        }

                        Console.Write("Enter base price:");
                        basePrice = Convert.ToDouble(Console.ReadLine());
                        if (basePrice < 0)
                        {
                            throw new PositiveException("Base price must be > 0", basePrice);
                        }
                        listAuto[index] = new Struct(id, basePrice, year, weight, addedPrice);
                        index++;

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (DuplicateException exDp)
                    {
                        Console.WriteLine(exDp.Message);
                    }
                    catch (PositiveException exP)
                    {
                        Console.WriteLine(exP.Message);
                        Console.WriteLine("Current base price: " + exP.basePrice);
                    }
                }
                if(choice == 3)
                {
                    for(int i = 0; i< index; i++)
                    {
                        Console.WriteLine(listAuto[i].ToString());
                    }
                }
                if (choice == 0)
                    break;
            }
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.WriteLine("1.Enter Car info");
            Console.WriteLine("2.Enter Struct info");
            Console.WriteLine("3.Display all auto");
            Console.Write("--->Enter your choice:");
        }
    }
}
