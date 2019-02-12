using LAB1.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1.GUI
{
    class Program
    {
        public static void LengthChangeHandle( int newLength)
        {
            Console.WriteLine("Length of collection changed to " + newLength.ToString());
        }
        static void Main(string[] args)
        {
            AutoCollection autoList = new AutoCollection();
            autoList.LengthChanged += LengthChangeHandle;
            while (true)
            {
                int choice = 0;
                Menu();

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    string InputFile = @"D:\auto.txt";
                    autoList.ReadFromFile(InputFile);
                    autoList.Display();
                }
                if (choice == 2)
                {
                    int id, year = 2016, numOfPass;
                    double basePrice, pricePerPass = 7.9;
                    try
                    {
                        Console.Write("Enter ID:");
                        id = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in autoList.listItem)
                        {
                            if (id == item.id)
                            {
                                throw new DuplicateException("ID is exist");
                            }
                        }
                        Console.Write("Enter Number of Passenger:");
                        numOfPass = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter base price:");
                        basePrice = Convert.ToDouble(Console.ReadLine());
                        if (basePrice < 0)
                        {
                            throw new PositiveException("Base price must be > 0", basePrice);
                        }
                        autoList.AddItem(new Car(id, basePrice, year, numOfPass, pricePerPass));

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
                if (choice == 3)
                {
                    int id, year = 2016, weight = 23;
                    double basePrice, addedPrice = 3.9;
                    try
                    {
                        Console.Write("Enter ID:");
                        id = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in autoList.listItem)
                        {
                            if (id == item.id)
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
                        autoList.AddItem(new Struct(id, basePrice, year, weight, addedPrice));
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
                if (choice == 4)
                {
                    autoList.Display();
                }
                if (choice == 5)
                {
                    int rmOption;
                    Console.WriteLine("1.Remove car");
                    Console.WriteLine("2.Remvove struct");
                    Console.Write("Enter option:");
                    rmOption = Convert.ToInt32(Console.ReadLine());
                    Auto itemRemove;
                    if (rmOption == 1)
                    {
                        int id, year = 2016, numOfPass;
                        double basePrice, pricePerPass = 7.9;
                        try
                        {
                            Console.Write("Enter ID:");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Number of Passenger:");
                            numOfPass = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter base price:");
                            basePrice = Convert.ToDouble(Console.ReadLine());
                            if (basePrice < 0)
                            {
                                throw new PositiveException("Base price must be > 0", basePrice);
                            }
                            itemRemove = new Car(id, basePrice, year, numOfPass, pricePerPass);
                            autoList.RemoveItem(itemRemove);
                            autoList.Display();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (PositiveException exP)
                        {
                            Console.WriteLine(exP.Message);
                            Console.WriteLine("Current base price: " + exP.basePrice);
                        }
                    }
                    if (rmOption == 2)
                    {
                        int id, year = 2016, weight = 23;
                        double basePrice, addedPrice = 3.9;
                        try
                        {
                            Console.Write("Enter ID:");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter base price:");
                            basePrice = Convert.ToDouble(Console.ReadLine());
                            if (basePrice < 0)
                            {
                                throw new PositiveException("Base price must be > 0", basePrice);
                            }
                            itemRemove = new Struct(id, basePrice, year, weight, addedPrice);
                            autoList.RemoveItem(itemRemove);
                            autoList.Display();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (PositiveException exP)
                        {
                            Console.WriteLine(exP.Message);
                            Console.WriteLine("Current base price: " + exP.basePrice);
                        }
                    }

                }
                if (choice == 6)
                {
                    int searchOption;
                    Console.WriteLine("1.Search car");
                    Console.WriteLine("2.Search struct");
                    Console.Write("Enter option:");
                    searchOption = Convert.ToInt32(Console.ReadLine());
                    Auto itemSearch;
                    int indexSearchItem;
                    if (searchOption == 1)
                    {
                        int id, year = 2016, numOfPass;
                        double basePrice, pricePerPass = 7.9;
                        try
                        {
                            Console.Write("Enter ID:");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Number of Passenger:");
                            numOfPass = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter base price:");
                            basePrice = Convert.ToDouble(Console.ReadLine());
                            if (basePrice < 0)
                            {
                                throw new PositiveException("Base price must be > 0", basePrice);
                            }
                            itemSearch = new Car(id, basePrice, year, numOfPass, pricePerPass);
                            indexSearchItem = autoList.SearchItem(itemSearch);
                            Console.WriteLine("Index of item: {0}", indexSearchItem);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (PositiveException exP)
                        {
                            Console.WriteLine(exP.Message);
                            Console.WriteLine("Current base price: " + exP.basePrice);
                        }
                    }
                    if (searchOption == 2)
                    {
                        int id, year = 2016, weight = 23;
                        double basePrice, addedPrice = 3.9;
                        try
                        {
                            Console.Write("Enter ID:");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter base price:");
                            basePrice = Convert.ToDouble(Console.ReadLine());
                            if (basePrice < 0)
                            {
                                throw new PositiveException("Base price must be > 0", basePrice);
                            }
                            itemSearch = new Struct(id, basePrice, year, weight, addedPrice);
                            indexSearchItem = autoList.SearchItem(itemSearch);
                            Console.WriteLine("Index of item: {0}", indexSearchItem);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (PositiveException exP)
                        {
                            Console.WriteLine(exP.Message);
                            Console.WriteLine("Current base price: " + exP.basePrice);
                        }
                    }
                }
                if (choice == 7)
                {
                    autoList.SortList(new IdComparer());
                    Console.WriteLine("----- Sort by id -----");
                    autoList.Display();

                    autoList.SortList(new BasePriceComparer());
                    Console.WriteLine("----- Sort by base price -----");
                    autoList.Display();
                }
                if (choice == 8)
                {
                    string OutputFile = @"D:\outputAuto.txt";
                    autoList.WriteToFile(OutputFile);
                }
                if (choice == 0)
                    break;
            }
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.WriteLine("1.Get auto form file.");
            Console.WriteLine("2.Enter Car info.");
            Console.WriteLine("3.Enter Struct info.");
            Console.WriteLine("4.Display all auto.");
            Console.WriteLine("5.Remove an item.");
            Console.WriteLine("6.Search item.");
            Console.WriteLine("7.Sort list item.");
            Console.WriteLine("8.Export file");
            Console.WriteLine("0.Exit program.");
            Console.Write("--->Enter your choice:");
        }
    }
}
