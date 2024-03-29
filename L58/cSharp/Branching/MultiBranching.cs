using Util;
namespace Branching
{
    class MultiBranching
    {
        public static void RunAll(){
            Console.WriteLine("---Branching: Multi Branching---");
            //Three @see Switches.cs
            Console.WriteLine("---alternative solutions---");
            One_();
            Two_();
            Four_();
        }
        
        private static void One_(){
            int number = Reader.TryNumericRead<int>("Insert Number from 1 - 5: ");
            //a data class that saves an key and a value and the key represents a value -> here {key:int -> value:String}
            Dictionary<int,String> sRep = new Dictionary<int, string>(){
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"},
                {5,"five"}
            };//you can get the value with the corresponding key
            Console.WriteLine("You entered the number {0}!", sRep.GetValueOrDefault(number,"ERROR!"));
        }

        /// <summary>
        /// lamda functions
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
        /// </summary>
        private static void Two_(){
            Dictionary<int,Func<int,double>> pricing = new Dictionary<int, Func<int, double>>//(lamda) Func is a short cut for simple functions -> here it takes an int and gives a double back
            {
                { 199, (x) => x * 0.06 },
                { 99, (x) => x * 0.08 },
                { 49, (x) => x * 0.09 },
                { 1, (x) => x * 0.1 }
            };
            Dictionary<int,Func<int,double>>.KeyCollection bounds = pricing.Keys;

            int copys = Reader.TryNumericRead<int>("Enter number of copys: ");
            foreach(int bound in bounds){
                if (bound < copys){
                    Console.WriteLine("Pice per copy: {0:0.00}",pricing.GetValueOrDefault(bound,(x)=>-1)(1));
                    Console.WriteLine("You have to pay: {0:0.00}€", pricing.GetValueOrDefault(bound,(x)=>-1)(copys));
                    return;
                }
            }
        }
        private static void Four_(){
            int number = Reader.TryNumericRead<int>("Insert Number from 1 - 5: ");
            Dictionary<int,String> sRep = new Dictionary<int, string>(){
                {1,"Schal rot, 10 €"},
                {2,"Schal gelb, 8 €"},
                {3,"thHemd weiß, Größe 44, 50 €"},
                {4,"Hemd weiß, Größe 46, 50 €"},
                {5,"Hemd weiß, Größe 48, 50 €"},
                {7,"Hemd weiß, Größe 50, 50 €"},
                {8,"Hose schwarz, Größe 48, 80 €"},
                {9,"Hose schwarz, Größe 50, 80 €"},
                {11,"Hose schwarz, Größe 52, 80 €"},
                {12,"Hose schwarz, Größe 54, 80 €"}
            };
            String value = sRep.GetValueOrDefault(number,"ERROR");
        }
    }    
}