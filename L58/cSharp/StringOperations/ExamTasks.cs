using Util;

namespace StringOperations{
    class ExamTasks{
        public static void RunAll(){
            Run();
            Run_();
        }
        public static void Run(){

        }
        public static void Run_(){
            //Winter();
            Summer();
        }

        private static void Summer(){
            //string[] inputs = Reader.MultiRead(new string[1]);
            string[] inputs = File.ReadAllLines("/workspaces/E_FI2/L58/cSharp/StringOperations/ExamTaskData.txt");
            int pos = Reader.TryNumericRead<int>("pos: ");
            string newData = "";
            foreach(string data in inputs){
                string[] dataParts =  data.Split("|");
                newData += dataParts[pos] + "|" + data.Replace("|" + dataParts[pos],"");
                newData += "\n";
            }
            Console.WriteLine(newData);
        }

        private static void Winter(){
            string input = Reader.Read("Enter ID: ");
            string printer = input[..2];
            string number = input[2..11];
            Console.WriteLine($"{printer} - {number}");
            int sum = 0;
            foreach(char symbol in number){
                sum += int.Parse(symbol.ToString());
            }
            sum += PositionInAlphabet(printer[0]) + PositionInAlphabet(printer[1]);
            int checkNumber = 7 - sum%9;
            if(checkNumber == int.Parse(input[input.Length - 1].ToString())){
                Console.WriteLine($"check number {checkNumber} is correct");
            }else{
                Console.WriteLine($"check number {checkNumber} is not correct");
            }
        }

        private static int PositionInAlphabet(char symbol){
            if(symbol > 64 && symbol < 91){
                return symbol - 64;
            }else if(symbol > 96 && symbol < 123){
                return symbol - 96;
            }else{
                throw new Exception($"Symbol {symbol} isnt part of the Alphabet");
            }
        }
    }
}