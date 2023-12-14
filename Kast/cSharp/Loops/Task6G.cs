using Util;
namespace Loops{
    class Task6G{
        
        public static void RunAll(){
            Console.WriteLine("---Loops: Task 6G---");
            Task1To4();
            Task5To6();
        }

        public static void Task1To4(){
            do {
                //Zufallsgeneratorinstanz aus Klasse Random erstellen
                Random zufall = new();
                //Zufallszahl zwischen 1 und 9/99/999 finden
                Console.WriteLine("Enter Area (9, 99, 999):");
                int area = int.Parse(Console.ReadLine());
                int zahl = zufall.Next(1,area);
                Console.WriteLine($"Zahlenraten\nFinde die Zahl von 1 bis {area}!");
                int i = 1;
                int tipp = 0;//todo add printing of curr player
                do{
                    Console.Write("der {0}. Tipp: ",i);
                    tipp = Convert.ToInt32(Console.ReadLine());
                    i++;
                    Console.WriteLine(zahl < tipp ? $"{tipp} ist zu groß" : $"{tipp} ist zu klein");
                }while(tipp != zahl);
                Console.WriteLine("\nRichtig! Das waren {0} Versuche", i - 1);
                Console.WriteLine("Again? (y / n)");
            }while(Console.ReadLine().ToLower().Equals("y"));
        }
        public static void Task5To6(){
            do{
                int area = Reader.TryNumericRead<int>("Enter area (9/99/999): ");
                int numberOne = Reader.TryNumericRead<int>("Enter Number for player one: ");
                int numberTwo = Reader.TryNumericRead<int>("Enter Number for player two: ");
                Console.WriteLine($"Zahlenraten\nFinde die Zahl von 1 bis {area}!");
                int countOne = 1;
                int countTwo = 1;
                int tipp = 0;
                bool player = true;
                do{
                    player = player != true;
                    Console.Write("der {0}. Tipp: ", player == true ? countOne : countTwo);
                    tipp = Convert.ToInt32(Console.ReadLine());
                    int temp = player == true ? countOne++ : countTwo++;
                    Console.WriteLine((player == true ? numberOne : numberTwo) < tipp ? $"{tipp} ist zu groß" : $"{tipp} ist zu klein");
                }while(tipp != (player == true ? numberOne : numberTwo));
                Console.WriteLine("\nRichtig! Das waren {0} Versuche", player == true ? countOne : countTwo);
                Console.WriteLine("Again? (y / n)");
            }while(Console.ReadLine().ToLower().Equals("y"));
        }
    }
}