using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Text;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int j = 0; j < myArray.Length; j++)
            {
                Console.Write($"\nВведите элемент массива под индексом {j}:\t");
                myArray[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            int syze = myArray.Length;


            for (int a = 0; a < syze - 1; a++)
            {
                for (int s = (syze - 1); s > a; s--)
                {
                    if (myArray[s - 1] > myArray[s])
                    {
                        int temp = myArray[s - 1];
                        myArray[s - 1] = myArray[s];
                        myArray[s] = temp;
                    }
                }
            }


            Console.ReadKey(); 
        }
    }
}


