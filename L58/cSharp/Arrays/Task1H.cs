using Util;

namespace Arrays
{
    class Task1H
    {
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1H---");
            Task();
        }   
        public static void Task(){
            //const int max = 14;
            //const int min = 2;
            int min = Reader.TryNumericRead<int>("min: ");
            int max = Reader.TryNumericRead<int>("max: ");
            int values = Reader.TryNumericRead<int>("values: ");
            
            values = values > 100 ? 100 : values;
            int[] array  = Reader.NumericMultiRead<int>(new string[values]);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    array[i] = min;   
                }
                if (array[i] > max)
                {
                    array[i] = max;   
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);   
            }
        }
    }
}