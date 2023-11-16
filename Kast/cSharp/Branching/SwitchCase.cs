using Util;
namespace Branching{
    class SwitchCase{
        public static void Main(String[] args){
        new WendingMachine().Buy();
    }

    private class WendingMachine{

        private readonly String _water = "water";
        private readonly double _waterPrice = 0.5;
        private readonly String _limo = "limo";
        private readonly double _limoPrice = 1.0;
        private readonly String _beer = "beer";
        private readonly double _beerPrice =2.0;

        public WendingMachine(){

        }

        public void Buy(){
            Console.WriteLine("Choose a drink:\n" +
            "1: {0} - {1:0.00}€\n" +
            "2: {2} - {3:0.00}€\n" +
            "3: {4} - {5:0.00}€\n",
            _water,_waterPrice,_limo,_limoPrice,_beer,_beerPrice);
            double price = GetPrice(Reader.NumericLRead<int>("Enter Product number: "));
            if (price < 0)
            {
                Console.WriteLine("Invalid Option!");
                return;
            }
            Console.WriteLine("Please insert {0:0.00}€",price);
            double insert = Reader.NumericLRead<double>(": ");
            double returnD = insert - price;
            if (returnD >= 0)
            {
                if(returnD > 0)
                {
                    Console.WriteLine("Your retrun is {0:0.00}€", returnD);
                }
                Console.WriteLine("Enjoy your drink!");
            }else{
                Console.WriteLine("Insuficient amount!");
            }
        }

        private double GetPrice(int input){
            switch (input)
            {
                case 1:
                    return _waterPrice;
                case 2:
                    return _limoPrice;
                case 3:
                    return (Reader.Read("older then 16? (y/n): ")).ToLower().Equals("y") ?
                    _beerPrice : -1;
                default:
                    return -1;
            }
        }
    }
    }
}