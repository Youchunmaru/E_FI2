using Util;

namespace Arrays{
    class Task1E{
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1E---");
            Task();
        }
        private static void Task(){
            int[] tip = Reader.NumericMultiRead<int>("1: ","2: ","3: ","4: ","5: ","6: ");
            int[] ints = new int[6];
            Random random = new Random();
            for(int i = 0; i < ints.Length; i++){
                int rand = random.Next(1,50);
                if(ints.Contains(rand)){
                    i--;
                    continue;
                }
                ints[i] = rand;
            }
            Console.WriteLine($"Your tip was: {tip}\nThe answer was: {ints}");
            foreach(int val in ints){
                Console.Write(tip.Contains(val) ? $"{val} was correcty tipped\n" : "");
            }
        }
    }
}