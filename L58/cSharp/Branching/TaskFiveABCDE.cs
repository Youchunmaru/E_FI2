using Util;
namespace Branching {
    class TaskFiveABCDE {
        
    public static void RunAll(){
        Console.WriteLine("---Branching: Task 5ABCDE---");
        FiveA();
        FiveB();
        FiveC();
        FiveD();
        FiveE();
    }

    private static void FiveA(){
        int firstNumber = Reader.TryNumericRead<int>("Enter first number:");
        int secondNumber = Reader.TryNumericRead<int>("Enter second Number:");
        Console.WriteLine(firstNumber > secondNumber ? $"{firstNumber} > {secondNumber}" :
         $"{firstNumber} < {secondNumber}");
    }

    private static void FiveB(){
        int firstNumber = Reader.TryNumericRead<int>("Enter first number:");
        int secondNumber = Reader.TryNumericRead<int>("Enter second Number:");
        Console.WriteLine(firstNumber == secondNumber ? "equals" : "!equals");
    }

    private static void FiveC(){
        Console.WriteLine("Enter school marks:");
        double math = Reader.TryNumericRead<double>("math: ");
        double german = Reader.TryNumericRead<double>("german: ");
        double physik = Reader.TryNumericRead<double>("physik: ");

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
        int number = Reader.TryNumericRead<int>("Enter number:");
        Console.WriteLine(number >= 0 ? number : -number);
    }

    private static void FiveE(){
        double price = Reader.TryNumericRead<double>("Enter price: ");
        String isMember = Reader.Read("Is Member? (y/n): ");
        if(isMember.ToLower().Equals("y")){
            Console.WriteLine($"price is: {price*0.95:0.00}");
        }else if (isMember.ToLower().Equals("n")){
            Console.WriteLine($"price is: {price:0.00}");
        }else {
            Console.WriteLine("Couldnt read answer! Applaying normal status!");
            Console.WriteLine($"price is: {price:0.00}");
        }
    }
    }
}