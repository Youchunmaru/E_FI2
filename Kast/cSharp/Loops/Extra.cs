using Util;
using System.Text;

namespace Loops
{
    class Extra
    {
        public static void RunAll(){
            Console.WriteLine("---Loops: Extra---");
            TaskOneA();
            TaskOneBC();
            TaskTwo();
            TaskThree();
            TaskFourA();
            TaskFourB();
            TaskFourC();
            TaskFive(); 
        }

        private static void TaskOneA(){
            double number = 220;
            const double rate = 0.01;
            int year = 2009;
            Console.WriteLine("Year | Number");
            while (year < 2060)
            {
                number *= 1 + rate;
                Console.WriteLine($"{year++} | {number:0}");
            }
        }

        private static void TaskOneBC(){//todo make better
            int simulations = Reader.TryNumericRead<int>("Enter number of simulations: ");
            double[] average = new double[52];
            average[0] = 220;
            for (int i = 0; i < simulations; i++)
            {
                Random random = new Random();
                double[] growth = new double[52];
                growth[0] = 220;
                average[0] += growth[0];
                int count = 1;
                int year = 2009;
                while (year < 2060)
                {
                    growth[count] = growth[count - 1] * (1 + ((random.NextDouble()*7-2.5)/100));// creates a factor between 1.025 - 1.045
                    average[count] += growth[count];
                    year++;
                    count++;
                }
            }
            Console.WriteLine("Year | Number");
            int y = 2009;
            for(int i = 0; i < average.Length; i++){
                Console.WriteLine($"{y++} | {average[i]/simulations:0}");
            }
        }
        private static void TaskTwo(){
            Console.WriteLine($"smallest divider: {Euclid(1337,13)}");
        }
        private static int Euclid(int a, int b){
            if(b == 0){
                return a;
            }else{
                return Euclid(b, a % b);
            }
        }

        private static void TaskThree(){

        }

        private static void TaskFourA(){
            Console.WriteLine("Phytagoras:");
            int a  = Reader.TryNumericRead<int>("FirstNumber: ");
            int b  = Reader.TryNumericRead<int>("SecondNumber: ");
            int c  = Reader.TryNumericRead<int>("ThirdNumber: ");
            Console.WriteLine($"{a}^2 + {b}^2 = {c}^2 is " + (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2) ? "true" : "false"));
        }

        private static void TaskFourB(){
            Console.WriteLine("Please wait while calculating number of phy triples");
            int count = 0;
            for (int a = 1; a < 1001; a++)
            {
                for (int b = 1; b < 1001; b++)
                {
                    for (int c = 1; c < 1001; c++)
                    {
                        if (PythagorasCheck(a,b,c))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"Number of phy triples: {count}");
        }

        private static bool PythagorasCheck(int a, int b, int c){
            return Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2);
        }

        private static void TaskFourC(){
            Console.WriteLine("Please wait while calculating number of advanced phy triples");
            int count = 0;
            for (int a = 1; a < 1001; a++)
            {
                for (int b = 1; b < 1001; b++)
                {
                    for (int c = 1; c < 1001; c++)
                    {
                        if (a < b && b < c && Euclid(c,b) == 1 && Euclid(b,a) == 1 && PythagorasCheck(a,b,c))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"Number of advanced phy triples: {count}");
        }

        private static void TaskFive(){
            Console.WriteLine("Sin plot: ");
            for (double i = 0; i < 100; i++)
            {
                double value = (Math.Sin(i) + 1) * 20;
                Console.WriteLine(RepeatStrBuilder(" ",(int)value) + "*");
                i -= 0.5;
            }
        }

        public static string RepeatStrBuilder(String text, int n)
        {
            return new StringBuilder(text.Length * n)
                .Insert(0, text, n)
                .ToString();
        }
    }  
}