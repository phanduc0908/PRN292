using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[111];
            int index=0;
            while (true)
            {
                try
                {
                    int id;
                    string name;
                    Console.WriteLine("Enter ID and name of employee:");
                    id = Convert.ToInt32(Console.ReadLine().Trim());
                    if (id < 0 || id > 100)
                    {
                        throw new IndexOutOfRangeException("ID in range[1-99]");
                    }
                    if (id == 0)
                        break;
                    for(int i=0; i<index; i++)
                    {
                        if(employee[i].id == id)
                        {
                            throw new DuplicateException("ID is exist", employee[i].name);
                        }
                    }
                    name = Console.ReadLine();
                    employee[index] = new Employee(id, name);
                    index++;
                    Console.WriteLine("-------");
                    Console.WriteLine("ID = {0}, Name = {1}", id, name);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    //      Console.WriteLine(e.HelpLink);
                }
                catch(DuplicateException ex1)
                {
                    Console.WriteLine(ex1.Message);
                    Console.WriteLine("Name have id:" + ex1.name);
                }
                finally
                {
                    Console.WriteLine("Thanks");
                }
            }


            Console.ReadLine();
        }
    }
}
