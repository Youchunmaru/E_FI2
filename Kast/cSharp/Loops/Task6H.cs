namespace Loops{
    class Task6H{
        public static void RunAll(){
            Console.WriteLine("---Loops: Task 6H");
            Task();
        }

        public static void Task(){
            Random random = new Random();
            int count = 0;
            for(int i = 0; i < 100; i++){
                int noshows = 0;
                for(int k = 0; k < 78; k++){
                    if(random.NextDouble() > 0.95){
                        noshows++;
                    }
                }
                if(noshows > 3){
                    count++;
                }
            }
            Console.WriteLine($"In 100 shows his sheme didn't work {count} times");
        }
    }
}