using Util;

namespace Arrays
{
    class Task1G
    {
      public static void RunAll(){
        Console.WriteLine("---Arrays: Task 1G---");
        Task();
      }

      public static void Task(){
        int sets = Reader.TryNumericRead<int>("How many sets will be entered? : ");
        double[,] array = new double[sets,3];
        for (int i = 0; i < sets; i++)
        {
            double[] ints = Reader.NumericMultiRead<double>("U: ","I: ");
            array[i,0] = ints[0];
            array[i,1] = ints[1];
            array[i,2] = ints[0]/ints[1];
        }
        Console.WriteLine("U - I - Ohm");
        for (int i = 0; i < sets; i++)
        {
          Console.WriteLine($"{array[i,0]} - {array[i,1]} - {array[i,2]}");
        } 
      }
    }
}