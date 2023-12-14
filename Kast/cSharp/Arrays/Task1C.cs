namespace Arrays{
    class Task1C{
        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1C---");
            Task();
        }

        private static void Task(){
            int[] ints = new int[10];
            int start = 50;
            for(int i = 0; i < 10; i++){
                ints[i] = start++;
            }
            foreach(int val in ints){
                Console.WriteLine(val);
            }
        }
    }
}