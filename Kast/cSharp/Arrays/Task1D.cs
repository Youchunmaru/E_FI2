namespace Arrays {
    class Task1D{
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1D---");
            Task();
        }
        private static void Task(){
            int[] ints = new int[6];
            Random random = new Random();
            for(int i = 0; i < ints.Length; i++){
                int rand = random.Next(1,50);
                if(ints.Contains(rand)){
                    i--;
                    continue;
                }
                ints[i] = rand;
            }
            Console.WriteLine(ints);
        }
    }
}