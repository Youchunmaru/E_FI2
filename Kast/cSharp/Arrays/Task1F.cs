using Util;

namespace Arrays
{
    class Task1F
    {
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1F---");
            Task();
        }   
        private static void Task(){
            int first = Reader.TryNumericRead<int>("first: ");
            int second = Reader.TryNumericRead<int>("second: ");
            int[,] ints = PopulateArray();
            Console.WriteLine($"{first} * {second} = " + ints[first,second]);
        }

        private static int[,] PopulateArray(){
            int[,] array = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i,j] = i * j;
                }   
            }
            return array;
        }
    }
}