using Util;

namespace StringOperations{
    class AB01{
        public static void RunAll(){
            Run();
            Run_();
        }
        public static void Run(){
            string text1 = " Enthalte ich ein bestimmtes Zeichen wie z.B. ein %-Zeichen? ";
            string text2 = "Enthalte ich ein bestimmtes Zeichen wie z.B. ein %-Zeichen!";
            string text3 = " Enthalte ich eine bestimmte Zeichenfolge wie ABCD oder 123 ? ";
            string text4 = " Ich bin ein weiterer umgeschriebener Text? ";
            string groß = "ICH BIN SOO Groß";
            string klein = "ich bin soo groß";
            string vergleich_klein = "ich bin soo groß";
            string meineGröße = "ich bin soo groß";
            string plus = "Gratulation";

            // a:
            Console.WriteLine($"length of text3: {text3.Length}");
            // b:
            Console.WriteLine($"text1 contains %: {text1.Contains('%')}");
            //c:
            Console.WriteLine($"text2 ends with ?: {text2.EndsWith('?')}");
            //d:
            Console.WriteLine($"index of % in text1: {text1.IndexOf('%')}");
            //e:
            Console.WriteLine($"substring of 7 - 10 in text4: {text4.Substring(6,4)}");
            //f: -> deletes trailing spaces
            Console.WriteLine($"length of text1 without and with trim: {text1.Length} - {text1.Trim().Length}");
            //g:
            Console.WriteLine($"groß == klein: {groß.Equals(klein)}");
            Console.WriteLine($"vergelich_klein == klein: {vergleich_klein.Equals(klein)}");
            Console.WriteLine($"klein compared to groß: {klein.CompareTo(groß)}");
            //h:
            Console.WriteLine($"groß: {groß.ToLower()}");
            Console.WriteLine($"klein: {groß.ToUpper()}");
            //i:
            Console.WriteLine($"meine größr replaced: {meineGröße.Replace("soo","1.90")}");
            //j:
            plus = plus.PadLeft(plus.Length+3,'+');
            Console.WriteLine($"plus: {plus.PadRight(plus.Length+3,'+')}");
            //k:
            text1.Split(" ").ForEach(it => Console.WriteLine(it));
        }
        public static void Run_(){

        }
    }
}