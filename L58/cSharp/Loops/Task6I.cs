namespace Loops{
    class Task6I{
        public static void RunAll(){
            Console.WriteLine("---Loops: Task 6I---");
            Run();
            Console.WriteLine("---alternative solution---");
            Run_();
        }

        public static void Run(){
            Task();
        }

        public static void Run_(){
            Task_();
        }

        public static void Task(){
            int sum = 0;
            for(int i = 3001; i < 5000; i += 2){
                sum += i;
            }
            Console.WriteLine(sum);
        }
        /// <summary>
        /// gaussien implementaion of sum(lower_bound, higher_bound)
        /// 
        /// <seealso cref="https://de.wikipedia.org/wiki/Gau%C3%9Fsche_Summenformel"/>
        /// </summary>
        public static void Task_(){
            int lower = 3000;
            int higher = 5000;
            int sum = (lower + higher)*(higher - lower)/2;
            Console.WriteLine(sum/2);
        }
    }
}