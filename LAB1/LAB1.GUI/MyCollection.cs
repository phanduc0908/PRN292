using System;
using System.Collections.Generic;

namespace LAB1.GUI
{
    class MyCollection<T>
    {
        public delegate void OnLengthChanged(int newLength);
        public event OnLengthChanged LengthChanged;

        public List<T> listItem { get; set; }
        public MyCollection()
        {
            listItem = new List<T>();
        }

        public int GetLength()
        {
            return listItem.Count;
        }

        public T GetItemByPosition(int index)
        {
            try
            {
                return listItem[index];
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool AddItem(T item)
        {
            try
            {
                for (int i = 0; i < listItem.Count; i++)
                    if (listItem[i].Equals(item))
                        throw new ExistingItemException(listItem.ToString());
                listItem.Add(item);
                if (LengthChanged != null) LengthChanged(listItem.Count);
                return true;
            }
            catch (ExistingItemException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool RemoveItem(T item)
        {
            try
            {
                listItem.Remove(item);
                if (LengthChanged != null) LengthChanged(listItem.Count);
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public int SearchItem(T item)
        {
            for(int i = 0; i< listItem.Count; i++)
            {
                if (item.Equals(listItem[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void SortList()
        {
            listItem.Sort();
        }
        public void SortList(IComparer<T> compare)
        {
            listItem.Sort(compare);
        }
        public void Display()
        {
            foreach(T item in listItem)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
