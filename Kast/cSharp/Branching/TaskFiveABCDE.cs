using Util;
namespace Branching {
    class TaskFiveABCDE {
        
    public static void Run(){
        FiveAB();
        FiveC();
        FiveD();
        FiveE();
    }

    private static void FiveAB(){
        int firstNumber = Reader.NumericLRead<int>("Enter first number:");
        int secondNumber = Reader.NumericLRead<int>("Enter second Number:");
        Console.WriteLine(firstNumber > secondNumber ? firstNumber + " > " + secondNumber :
         firstNumber + " < " + secondNumber);
        Console.WriteLine(firstNumber == secondNumber ? "equals" : "!equals");
    }

    private static void FiveC(){
        Console.WriteLine("Enter school marks:");
        double math = Reader.NumericLRead<double>("math: ");
        double german = Reader.NumericLRead<double>("german: ");
        double physik = Reader.NumericLRead<double>("physik: ");

        double mark = (math + german + physik)/3.0;
        if(math >= 6 || german >= 6){
            Console.WriteLine("Durchgefallen mit: {0:0.00}", mark);
        }else if(mark >= 3.5){
            Console.WriteLine("Durchgefallen mit: {0:0.00}", mark);
        }else{
            Console.WriteLine("Bestanden mit: {0:0.00}", mark);
        }
    }

    private static void FiveD(){
        int number = Reader.NumericLRead<int>("Enter number:");
        Console.WriteLine(number >= 0 ? number : -number);
    }

    private static void FiveE(){
        double price = Reader.NumericLRead<double>("Enter price: ");
        String isMember = Reader.Read("Is Member? (y/n): ");
        if(isMember.ToLower().Equals("y")){
            Console.WriteLine("price is: {0:0.00}",price*0.95);
        }else if (isMember.ToLower().Equals("n")){
            Console.WriteLine("price is: {0:0.00}", price);
        }else {
            Console.WriteLine("Couldnt read answer! Applaying normal status!");
            Console.WriteLine("price is: {0:0.00}",price);
        }
    }
    }
}