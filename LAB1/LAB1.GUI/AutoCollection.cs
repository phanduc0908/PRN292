using LAB1.CORE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1.GUI
{
    class AutoCollection:MyCollection<Auto>
    {
        public AutoCollection() :base()
        {
        }
        public Auto CreateItem(string line)
        {
            string[] item = line.Trim().Split('|');
            int id = Convert.ToInt32(item[1]);
            double basePrice = Convert.ToDouble(item[2]);
            int year = Convert.ToInt32(item[3]);
            if (item[0] == "1") // Car
            {
                int numOfPassenger  = Convert.ToInt32(item[4]);
                double pricePerPass = Convert.ToDouble(item[5]);
                return new Car(id, basePrice, year, numOfPassenger, pricePerPass);
            }
            else
            {
                int weight = Convert.ToInt32(item[4]);
                double addedPrice = Convert.ToDouble(item[5]);
                return new Struct(id, basePrice, year, weight, addedPrice);
            }
        }
        public void ReadFromFile(string FileName)
        {
            try
            {
                StreamReader reader = new StreamReader(FileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                    AddItem(CreateItem(line));
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi trong luc doc file");
            }
        }

        public void WriteToFile(string FileName)
        {
            try
            {
                StreamWriter writer = new StreamWriter(FileName);
                for (int i = 0; i < GetLength(); i++)
                    writer.WriteLine(GetItemByPosition(i).ToString());
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Co loi trong qua trinh ghi file");
            }
        }
    }
}
