namespace Arrays{
    class Task1B{
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1B---");
            Task();
        }

        private static void Task(){
            int[] ints = new int[6];
            double[] doubles = new double[3];
            String[] strings = new string[4];
            Random random = new();
            for(int i = 0; i < ints.Length; i++){
                ints[i] = random.Next()*100;// init array pos i
                Console.WriteLine(ints[i]);// printing array pos i
            }//to lazy to seperate init and printing into two loops
            for(int i = 0; i < doubles.Length; i++){
                doubles[i] = random.Next()*100;
                Console.WriteLine(doubles[i]);
            }
             for(int i = 0; i < strings.Length; i++){
                strings[i] = $"{random.Next()*100}";
                Console.WriteLine(strings[i]);
            }
        }
    }
}