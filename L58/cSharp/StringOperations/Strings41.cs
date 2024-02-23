

namespace StringOperations{
    class Strings41{
        public static void RunAll(){
            Console.WriteLine("---String Operations: 41---");
            Run();
            Run_();
        }

        public static void Run(){
            One();
            Two();
            Three();
            Four();
            Five();
            Six();
        }
        public static void Run_(){
            One_();
        }

        private static void One(){
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine().ToUpper();
            double count = 0;
            foreach(char symbol in input){
                if (symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U'){
                    count++;
                }
            }
            Console.WriteLine($"Percentage: {(count/input.Length)*100.0}%");
        }
        private static void One_(){
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine().ToUpper();
            int count = input.Count(symbol => symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U');
            Console.WriteLine($"Percentage: {(count/input.Length)*100}%");
        }

        private static void Two(){
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            string output = input.Replace("ä","&auml").Replace("ö","&ouml").Replace("ü","&uuml");
            Console.WriteLine(output);
        }

        private static void Three(){
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Word count: ${input.Split(" ").Length}");
        }

        private static void Four(){
            Console.WriteLine("Enter a email: ");
            string input = Console.ReadLine();
            int at = input.IndexOf("@");
            int dot = input.LastIndexOf(".");
            if(at > 2 && (dot - at) > 2){
                if(input.EndsWith(".de")){
                    Console.WriteLine("Correct email!");
                } else{
                    Console.WriteLine("Wrong email!");
                }
        
            }else{
                Console.WriteLine("Wrong email!");
            }
        }

        private static void Five(){
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            string output = input.Replace("ä","ae").Replace("ü","ue").Replace("ö","oe");
            Console.WriteLine(output);
        }

        private static void Six(){
            Console.WriteLine("Enter binary: ");
            string input = "";
            do{
                input = Console.ReadLine();
            }while(!IsBinary(input));
            int number = 0;
            int pow = input.Length - 1;
            foreach(char symbol in input){
                number += (int) (int.Parse(""+ symbol) * Math.Pow(2,pow--));
            }
            Console.WriteLine($"{input} is {number}");
        }

        private static bool IsBinary(string value){
            foreach(char symbol in value){
                if(symbol != '0' && symbol != '1') return false;
            }
            return true;
        }
    }
}