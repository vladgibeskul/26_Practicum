namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Metod_Random(10, -10, 10);
            Output(array);
            Console.WriteLine($"Количество четных элементов: {Value(array)}");

            Console.ReadLine();
        }
        static int[] Metod_Random(int size, int min, int max)
        {
            int[] omas = new int[size];
            Random random = new Random();

            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next(-10, 10);
            }

            return omas;
        }


        static void Output(int[] array)
        {
            Console.WriteLine("Сгенерированный массив:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }


        static int Value(int[] array)
        {

            return array.Count(x => x % 2 == 0);
        }

    }
}
