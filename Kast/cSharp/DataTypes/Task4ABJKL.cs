using Util;
namespace DataTypes{
    class Task4ABJKL{
        public static void RunAll(){
            Run();
            Console.WriteLine(
                "-------------------------------------------------------------------------------------\n" +
                "--------------------------------alternative solutions--------------------------------\n" +
                "-------------------------------------------------------------------------------------");
            Run_();
        }

        public static void Run(){
            FourA();
            FourB();
            FourJ();
            FourK();
            FourL();
        }

        public static void Run_(){
            FourA_();
            FourB_();
            FourJ_();
            FourK_();
            FourL_();
        }

        private static void FourA(){
            double tax = 1.19;
            Console.WriteLine("Please Enter the price without tax ( x.xx ): ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Price with tax is: {0:0.00}€", price*tax);
        }

        private static void FourB(){
            Console.WriteLine("Please enter the radius ( x.xx ): ");
            double radius = double.Parse(Console.ReadLine());
            double circumfrence = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("A circle with radius {0:0.00} has: \n" + 
                              "circumfrence: {1:0.00}\n" + 
                              "area: {2:0.00}", 
                              radius, circumfrence, area);
        }

        private static void FourJ(){
            Console.WriteLine("Please enter your speed: ");
            int speed = int.Parse(Console.ReadLine());
            int distance = speed / 2;
            Console.WriteLine("The minmum distance at {0}km/h is {1}m", speed, distance);
        }

        private static void FourK(){
            //COPY
            Console.WriteLine("Please enter your speed: ");
            int speed = int.Parse(Console.ReadLine());
            int distance = speed / 2;
            Console.WriteLine("The minmum distance at {0}km/h is {1}m", speed, distance);
            //COPY
            double reactionDistance = speed * 3.0 / 10.0;
            double breakingDistance = speed / 10 * speed / 10;
            double haltingDistance = reactionDistance + breakingDistance;
            Console.WriteLine("The halting distance at {0}km/h is {1}", speed, haltingDistance);
        }

        private static void FourL(){
            short maxValue = 32767;
            Console.WriteLine("{0} + 1 = {1}", maxValue, ++maxValue);
        }
        /*-------------------------------------------------------------------------------------*/
        /*--------------------------------alternative solutions--------------------------------*/
        /*-------------------------------------------------------------------------------------*/
        private const double tax = 1.19;
        private static void FourA_(){
            double price = Reader.NumericRead<double>("Please Enter the price without tax ( x.xx ): ");
            Console.WriteLine("Price with tax is: {0:0.00}€", price * tax);
        }

        private static void FourB_(){
            double radius = Reader.NumericLRead<double>("Please enter the radius ( x.xx ): ");
            Console.WriteLine("A circle with radius {0:0.00} has: \n" + 
                              "circumfrence: {1:0.00}\n" + 
                              "area: {2:0.00}", 
                              radius, 
                              2 * Math.PI * radius, 
                              Math.PI * Math.Pow(radius,2));
        }

        private static void FourJ_(){
            int speed = Reader.NumericLRead<int>("Please enter your speed: ");
            Console.WriteLine("The minmum distance at {0}km/h is {1}m", speed, speed / 2);
        }

        private static void FourK_(){
            int speed = Reader.NumericLRead<int>("Please enter your speed: ");
            double reactionDistance = speed * 3.0 / 10.0;
            double breakingDistance = Math.Pow(speed / 10, 2);
            Console.WriteLine("The minmum distance at {0}km/h is {1}m", speed, speed / 2);
            Console.WriteLine("The halting distance at {0}km/h is {1}", speed, reactionDistance + breakingDistance);
        }

        private static void FourL_(){
            short maxValue = short.MaxValue;
            Console.WriteLine("{0} + 1 = {1}", maxValue, ++maxValue);
        }
    }
}