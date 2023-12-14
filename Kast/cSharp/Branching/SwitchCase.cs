using Util;
namespace Branching{
    class SwitchCase{
        public static void RunAll(){
            Console.WriteLine("---Branching: Switch Case---");
            SwitchCaseGetränkeautomaten();
            Task3A();
            Task3B();
            Console.WriteLine(
                "-------------------------------------------------------------------------------------\n" +
                "--------------------------------alternative solutions--------------------------------\n" +
                "-------------------------------------------------------------------------------------");
            new WendingMachine().Buy();
        }

        public static void SwitchCaseGetränkeautomaten(){
            const double WATER = 0.5;
            const double LIMO = 1.0;
            const double BEER =2.0;
            Console.WriteLine($"Choose a drink:\n" +
            $"1: Water - {WATER:0.00}€\n" +
            $"2: Limo - {LIMO:0.00}€\n" +
            $"3: Beer - {BEER:0.00}€\n");
            double price;
            Console.WriteLine("Enter number: ");
            switch (Console.ReadLine()){
                case "1":
                    price = WATER;
                    break;
                case "2":
                    price = LIMO;
                    break;
                case "3":
                    Console.WriteLine("Please enter your age: ");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 16) {
                        return;
                    }
                    price = BEER;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    return;
            }
            Console.WriteLine($"Please insert {price:0.00}€");
            double insert = double.Parse(Console.ReadLine());
            double returnAmount = insert - price;
            if (returnAmount >= 0)
            {
                if(returnAmount > 0)
                {
                    Console.WriteLine($"Your retrun is {returnAmount:0.00}€");
                }
                Console.WriteLine("Enjoy your drink!");
            }else{
                Console.WriteLine("Insuficient amount!");
            }
        }

        public static void Task3A(){
            switch(short.Parse(Console.ReadLine())){
                case >= 18:
                    Console.WriteLine("Yay, you are an adult now");
                    break;
                case >=16:
                    Console.WriteLine("Yay, cou can get a small motot bike licence");
                    break;
                default:
                    Console.WriteLine("Nothing interesting");
                    break;
            }
        }

        public static void Task3B(){
            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Are you female? ( y / n )");
            String answer = Console.ReadLine().ToLower();
            if (answer == "y"){
                name = "Frau" + name;
            }else{
                name = "Herr" + name;
            }
            //returns hours since 0 am of curr day
            int time = DateTime.Now.TimeOfDay.Hours;
            switch(time){
                case < 6:
                Console.WriteLine("Night");
                break;
                case < 12:
                Console.WriteLine("Morning");
                break;
                case < 16:
                Console.WriteLine("Noon");
                break;
                case < 22:
                Console.WriteLine("evening");
                break;
                default:
                break;
            }
        }

        /*-------------------------------------------------------------------------------------*/
        /*--------------------------------alternative solutions--------------------------------*/
        /*-------------------------------------------------------------------------------------*/

    private class WendingMachine{
        private readonly Selection<String, double> selection;

        public WendingMachine(){
            selection = new Selection<string, double>();
            selection.Add("Water",0.5).Add("Limo",1.0).Add("Beer",2.0);
        }

        private void PrintSelection(){
            Console.WriteLine("Choose a drink: ");
            for(int i = 0; i < selection.GetLenght(); i++){
                Console.WriteLine($"{i}: {selection.GetN(i)} - {selection.GetV(i):0.00}€");
            }
        }
        public void Buy(){
            PrintSelection();
            double price = GetPrice(Reader.TryNumericRead<int>("Enter Product number: "));
            if (price < 0)
            {
                Console.WriteLine("Invalid Option!");
                return;
            }
            Console.WriteLine($"Please insert {price:0.00}€");
            double insert = Reader.TryNumericRead<double>(": ");
            double returnAmount = insert - price;
            if (returnAmount >= 0)
            {
                if(returnAmount > 0)
                {
                    Console.WriteLine($"Your retrun is {returnAmount:0.00}€");
                }
                Console.WriteLine("Enjoy your drink!");
            }else{
                Console.WriteLine("Insuficient amount!");
            }
        }

        private double GetPrice(int input){
            if(selection.GetN(input).Equals("Beer")){
                return Reader.Read("older then 16? (y/n): ").ToLower().Equals("y") ?
                    selection.GetV(input) : -1;
            }
            return selection.GetV(input);
        }
        /// <summary>
        /// custom data list class
        /// </summary>
        /// <typeparam name="N">name</typeparam>
        /// <typeparam name="V">value</typeparam>
        private class Selection<N,V> {
            Dictionary<int,N> nD = new Dictionary<int, N>();
            Dictionary<int,V> vD = new Dictionary<int, V>();

            public Selection<N,V> Add(N n,V v){
                nD.Add(nD.Count,n);
                vD.Add(vD.Count,v);
                return this;
            }

            public N GetN(int key){
                return nD.GetValueOrDefault(key);
            }

            public V GetV(int key){
                return vD.GetValueOrDefault(key);
            }

            public int GetLenght(){
                return nD.Count;
            }
        }
    }
    }
}