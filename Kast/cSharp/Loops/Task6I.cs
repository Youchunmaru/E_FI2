using Util;
namespace Loops{
    class Task6I{
        public static void Run(){
            Task();
            Task_();
        }

        public static void Task(){
            int sum = 0;
            for(int i = 3000; i < 5001; i++){
                if(i%2 != 0){
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        public static void Task_(){
            int lower = 3000;
            int higher = 5000;
            int sum = (lower + higher)*(higher - lower)/2;
            Console.WriteLine(sum/2);
        }
    }
}