using System;
namespace Vovk.Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new ();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-10, 10);
            foreach (int number in array)
            {
                Console.Write($"{number} \t");
            }
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Меньшее: " + min);
            int b = array.Length - 2;
            array[b] = min;
            //перечисляет элементы коллекции и выполняет тело для каждого элемента коллекции.
            foreach (int number in array)
            {
                Console.Write($"{number} \t");
            }
        }
    }
}









