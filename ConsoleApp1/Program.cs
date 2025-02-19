using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = Input();
            Output(omas);

            Console.ReadKey();
        }
        public static int[] Input()
        {
            Console.Write("Введите количество элементов:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите элемент массива [{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }



        public static void Output(int[] array)
        {
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        
    }
}