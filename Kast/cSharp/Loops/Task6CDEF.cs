using Util;
namespace Loops{
    class Task6CDEF{
        public static void Run(){
            TaskC();
            TaskD();
            TaskE();
            TaskF();
        }
        public static void TaskC(){
            int value = 1;
            String calculation = "1";
            for(int i = 2; i < 11; i++){
                calculation += $" + {i}";
                value += i;
                Console.WriteLine($"{calculation} = {value}");
            }
        }

        public static void TaskD(){
            double x = 1;
            double n = 0;
            String calculation = "1";
            while(n < 2){
                n += x;
                Console.WriteLine($"{calculation} = {n}");
                x /= 2;
                calculation += $" + {x}";
            }
        }

        public static void TaskE(){
            for (int i = 1; i < 101; i++){
                if(i%7 == 0){
                    Console.WriteLine("*");
                    continue;
                }
                Console.WriteLine($"{i}");
            }
        }

        public static void TaskF(){
            double a = 60000000;
            double b = 4000000;
            int years = 0;
            while(a > b){
                a *= 0.995;
                b *= 1.025;
                years++;
            }
            Console.WriteLine($"B is bigger after {years} years");
        }
    }
}