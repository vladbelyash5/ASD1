using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Lab_Rab
{
    internal static class Test
    {
        public static void Main(string[] args)
        {
            
            List<int> array = new List<int>() { 8, 1, 2, 3, 4, 5, 6};
            List<int> otherArray = new List<int>() { 3, 2, 1, 8, 4};
            List<int> thirdArray = new List<int>();
            Set set = new Set(array);

            Console.Write("Union элементов в массив ===  ");
            set.union(otherArray);
            set.print();

            Console.Write("Нахождение индекса переменной ===  ");
            Console.WriteLine(set.getIndexOf(45));

            Console.Write("Проверка существования элемента в коллекции ===  ");
            Console.WriteLine(set.exists(101));

            Console.Write("Добавление элемента в коллекцию и вывод ===  ");
            set.add(6);
            set.print();

            Console.Write("Удаление элемента по значению из коллекции ===  ");
            set.remove(95);
            set.print();

            Console.Write("Удаление элемента по индексу из коллекции ===  ");
            set.removeAt(2);
            set.print();

            Console.WriteLine();
            set.Addition(otherArray, thirdArray);
        }
    }
}
