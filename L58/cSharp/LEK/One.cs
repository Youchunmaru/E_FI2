
namespace LEK
{
    class One
    {
        public static void RunAll(){
            Squares();
        }

        private static void Squares(){
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 1; i <= n; i++)
            {
                array[i-1] = i*i;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}