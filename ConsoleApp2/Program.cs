namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Random(10, -10, 10); 
            Print(array);
            int evenCount = Elements(array);
            Console.WriteLine("Количество четных элементов: " + evenCount);
        }
        
        static int[] Random(int size, int min, int max)
        {
            int[] omas = new int[size];
            Random random = new Random();

            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next(min, max + 1);
            }

            return omas;
        }

        
        static void Print(int[] array)
        {
            Console.WriteLine("Сгенерированный массив:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        
        static int Elements(int[] array)
        {
            return array.Count(x => x % 2 == 0);
        }
    }
}
