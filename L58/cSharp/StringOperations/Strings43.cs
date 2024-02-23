

namespace StringOperations{
    class Strings43{
        public static void RunAll(){
            Console.WriteLine("---String Operations: 43---");
            Run();
            Run_();
        }

        public static void Run(){
            One();
            Two();
        }
        public static void Run_(){
            
        }
        public static void One(){
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine().Replace("-","");
            bool odd = true;
            int oddNumber = 0;
            int evenNumber = 0;
            foreach(char symbol in input){
                if(odd){
                   oddNumber += int.Parse(""+symbol); 
                   odd = false;
                }else{
                    evenNumber += int.Parse(""+symbol); 
                    odd = true;
                }
            }
            Console.WriteLine($"alt sum {oddNumber} - {evenNumber}: {oddNumber - evenNumber}");
        }

        public static void Two(){
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine().ToUpper();
            int[] destribution = new int[26];
            const int A = 'A';
            const int Z = 'Z';
            foreach(char symbol in input){
                if(symbol >= A && symbol <= Z){
                    destribution[symbol-A]++;
                }
            }
            for(int i = 0; i < destribution.Length; i++){
                char symbol = (char)(i + A);
                Console.WriteLine($"{symbol}: {destribution[i]}");
            }
        }
    }
}