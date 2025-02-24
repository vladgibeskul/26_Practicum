namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array(10); 

            Print(array); 
        }

        
        static int[] Array(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i; 
            }

            return array; 
        }

       
        static void Print(int[] array)
        {
            Console.WriteLine("Элементы массива:");
            foreach (int element in array)
            {
                Console.Write(element + " "); 
            }
            Console.WriteLine(); 
        }
    }
}
