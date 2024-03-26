using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Lab_Rab
{
    public class Set
    {

        //public int n;
        public List<int> list = new List<int>();
        public Set(List<int> list) {  this.list = list; }


        /// <summary>
        /// метод для получения индекса элемента
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /*public Set(int n) 
        {
            this.n = n;
        }*/
        public int getIndexOf(int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// метод для проверки существования элемента в коллекции
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool exists(int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// метод для добавления элемента в массив
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        public void add(int value)
        {
            if (!list.Contains(value))
            {
                list.Add(value);
            }
        }

        /// <summary>
        /// метод удаляющий элемент массива по значению
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        public void remove(int value)
        {
            list.Remove(value);
        }

        /// <summary>
        /// метод удаляющий элемент по индексу
        /// </summary>
        /// <param name="list"></param>
        /// <param name="index"></param>
        public void removeAt(int index)
        {
            list.RemoveAt(index);
        }

        /// <summary>
        /// метод для красивого вывода в консоль
        /// </summary>
        /// <param name="list"></param>
        public void print()
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void union(List<int> otherList)
        {
            foreach (int item in otherList)
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
        }

        public void Addition(List<int> otherList, List<int> list3)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (otherList.Contains(list[i]))
                {
                    list3.Add(list[i]);
                }
            }
            foreach(int item in list3)
            {
                Console.Write(item + " ");
            }
        }
    }
}