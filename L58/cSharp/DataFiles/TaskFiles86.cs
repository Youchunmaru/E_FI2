using Util;

namespace DataFiles
{
    class TaskFiles86
    {
        public static void RunAll(){
            One();
            Two();
        }

        private static void One(){
            //alternative with Set
            const string path = "/home/user/E_FI2/L58/cSharp/DataFiles/30000haeufigsteWoerter.txt";
            string[] commonWords = File.ReadAllLines(path)
            .Select(it => it.Split(' ')[0].ToUpper()).Distinct().ToArray();
            File.WriteAllLines("/home/user/E_FI2/L58/cSharp/DataFiles/ausgabe.txt", commonWords);
        }
        private static void Two(){
            const string path = "/home/user/E_FI2/L58/cSharp/DataFiles/Zugang.txt";
            string[] logEntrys = File.ReadAllLines(path);
            string[] output = new string[logEntrys.Length];
            foreach (var entry in logEntrys)
            {
                string id = entry.Split(' ')[0];
                int sum = 0;
                foreach (var item in logEntrys)
                {
                    if (item.Split(' ')[0] == id)
                    {
                        sum += int.Parse(item.Split(' ')[2]);
                    }
                }
                if (sum >= (500))
                {
                    output.Append($"Too much for id {id}");
                }
            }
            output.Distinct().ToArray().ForEach(it => {
                Console.WriteLine(it);
            });
        }
    }
}