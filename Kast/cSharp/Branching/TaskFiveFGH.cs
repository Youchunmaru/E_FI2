using System.Numerics;
using Util;
namespace Branching{
    class TaskFiveFGH{

    
        private static void FiveF(){
            Console.WriteLine( Reader.NumericLRead<int>("Enter number: ") % 2 == 0 ? "even" : "uneven");
        }

        private static void FiveH(){

            const double inch = 0.0254;
            const double feet = 0.3048;
            const double yard = 0.9144;
            const double mile = 1609.34;

            Console.WriteLine("Convert to meter:\n" +
            "1: inch\n" +
            "2: feet\n" + 
            "3: yard\n" + 
            "4: mile\n");
            String number = Reader.Read("Enter conversion number: ");
            double value = Reader.NumericLRead<double>("Enter imperial value: ");
            switch(number){
                case "1":
                    Console.WriteLine($"{value} inch are {value*inch:0.000}m");
                    break;
                case "2":
                    Console.WriteLine($"{value} feet are {value*feet:0.000}m");
                    break;
                case "3":
                    Console.WriteLine($"{value} yard are {value*yard:0.000}m");
                    break;
                case "4":
                    Console.WriteLine($"{value} miles are {value*mile:0.000}m");
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