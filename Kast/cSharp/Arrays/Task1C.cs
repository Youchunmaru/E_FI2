namespace Arrays{
    class Task1C{
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1C---");
            Task();
        }

        private static void Task(){
            int[] ints = new int[10];
            for(int i = 50; i < 60; i++){
                ints[i] = i++;
            }
            foreach(int val in ints){
                Console.WriteLine(val);
            }
        }
    }
}