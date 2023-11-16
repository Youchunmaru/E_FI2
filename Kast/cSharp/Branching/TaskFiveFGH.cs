using System.Numerics;
using Util;
namespace Branching{
    class TaskFiveFGH{
        private static void FiveF(){
        Console.WriteLine( Reader.NumericLRead<int>("Enter number: ") % 2 == 0 ? "even" : "uneven");
    }

    private static void FiveH(){

        double inch = 0.0254;
        double feet = 0.3048;
        double yard = 0.9144;
        double mile = 1609.34;

        Console.WriteLine("Convert to meter:\n" +
        "1: inch\n" +
        "2: feet\n" + 
        "3: yard\n" + 
        "4: mile\n");
        int number = Reader.NumericLRead<int>("Enter conversion number: ");
        double value = Reader.NumericLRead<double>("Enter imperial value: ");
        switch(number){
            case 1:
                Console.WriteLine("{0} inch are {1:0.000}m", value, value*inch);
                break;
            case 2:
                Console.WriteLine("{0} feet are {1:0.000}m", value, value*feet);
                break;
            case 3:
                Console.WriteLine("{0} yard are {1:0.000}m", value, value*yard);
                break;
            case 4:
                Console.WriteLine("{0} miles are {1:0.000}m", value, value*mile);
                break;
        }

    }

    private class Calculator{
        private const String plus = "+";
        private const String minus = "-";
        private const String multiplicate = "*";
        private const String divide = "/";

        public Calculator(){}

        //generic solution
        public void Calculate<T>() where T:INumber<T>{
            T first = Reader.NumericLRead<T>("Enter first number ("+typeof(T)+"): ");
            String symbol = Reader.Read("Enter Operator ( + | - | * | / ): ");
            T second = Reader.NumericLRead<T>("Enter second number ("+typeof(T)+"): ");
            
            switch(symbol){
                case plus:
                    Console.WriteLine("{0} + {1} = {2}",
                    first, second, first + second);
                    break;
                case minus:
                    Console.WriteLine("{0} - {1} = {2}",
                    first, second, first - second);
                    break;
                case multiplicate:
                    Console.WriteLine("{0} * {1} = {2}",
                    first, second, first * second);
                    break;
                case divide:
                    Console.WriteLine("{0} / {1} = {2}",
                    first, second, first / second);
                    break;
            }           
        }

        //generic and full text
        public void CalculateText<T>() where T:INumber<T>{
            String[] calc =  Reader.Read("Enter ("+typeof(T)+") calc ( <x> <operator> <y> ):\n").Split(" ");
            T first = T.Parse(calc[0], null);
            String symbol = calc[1];
            T second = T.Parse(calc[2], null);
            switch(symbol){
                case plus:
                    Console.WriteLine("{0} + {1} = {2}",
                    first, second, first + second);
                    break;
                case minus:
                    Console.WriteLine("{0} - {1} = {2}",
                    first, second, first - second);
                    break;
                case multiplicate:
                    Console.WriteLine("{0} * {1} = {2}",
                    first, second, first * second);
                    break;
                case divide:
                    Console.WriteLine("{0} / {1} = {2}",
                    first, second, first / second);
                    break;
            }
        }
    }
    }
}