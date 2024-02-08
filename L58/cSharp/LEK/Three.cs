
namespace LEK
{
    class Three
    {
        public static void RunAll(){
            Tree();
        }

        private static void Tree(){
            Console.WriteLine("Enter tree size: ");
            int n = int.Parse(Console.ReadLine());
            int width = 1;
            String tree = "";
            for (int i = 0; i < n; i++)
            {
                tree += Repeat(" ", n - i) + Repeat("*",width++) + "\n";
                width++;
            }
            tree += Repeat(" ", width/2) + "|";
            Console.WriteLine(tree);
        }

        private static String Repeat(String symbol, int n){
            String repeat = "";
            for (int i = 0; i < n; i++)
            {
                repeat += symbol;
            }
            return repeat;
        }
    }
}