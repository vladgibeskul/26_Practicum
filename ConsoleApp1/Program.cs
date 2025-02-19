namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Value();
            Console.ReadKey();

        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Value()
        {
            int n = Input("Введите числа:");
            int[] array = new int[n];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine(); 

        }
    }
}
