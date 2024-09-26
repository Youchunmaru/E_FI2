using Util;

namespace ASP
{
    class Task_Winter_T1
    {
        public static void RunAll(){
            Run();
            Run_();
        }

        public static void Run(){
            Task1_3();
        }

        public static void Run_(){
            Task1_3_();
        }

        private static void Task1_3(){
            double distance = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double price;
            if (distance <= 25.0 && weight <= 12.0){
                if (weight <= 6)
                {
                    price = 3;
                }else{
                    price = 7;
                }
                Console.WriteLine($"The final price is {price + distance * 0.4}€");
            }
            Console.WriteLine($"The requested distance or weight is to big");
        }

        private static void Task1_3_(){
            double distance = Reader.TryNumericRead<double>("Enter distance");
            double weight = Reader.TryNumericRead<double>("Enter weight");
            Console.WriteLine(Flugpreise(distance, weight));
        }
        private static string Flugpreise(double d, double w){
            double price = w <= 6.0 ? 3.0 : 7.0;
            return d <= 25.0 ? $"he final price is {price + d * 0.4}€" : $"The requested distance or weight is to big";
        }
    }
}