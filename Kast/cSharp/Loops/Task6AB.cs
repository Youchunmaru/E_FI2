using Util;
namespace Loops{
    class Task6AB{
        public static void Run(){
            Task6A();
        }

        public static void Task6A(){
            Console.WriteLine("Emter your money: ");
            double startCapital = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your end Money: ");
            double endCapital = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your intrest rate: ");
            double intrest = double.Parse(Console.ReadLine());
            int years = 0;
            while(startCapital < endCapital){
                startCapital = startCapital * (1 + intrest);
                Console.WriteLine($"{++years}: {startCapital:0.00}€");
            }
            Console.WriteLine($"You reached your desired end capital after {years} years");
        }

        public static void Task6B(){
            do {
                Task6A();
                Console.WriteLine("Do you want to run the Programm again? ( y / n)");
            }while(Console.ReadLine().ToLower().Equals("y"));
        }
    }
}