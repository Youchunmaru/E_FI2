namespace Arrays{
    class Task1A{

        public static void RunAll(){
            Console.WriteLine("---Arrays: Task 1A---");
            Task();
        }

        private static void Task(){
            int[]  array = new int[]{1,2,3,4,5};
            foreach(int val in array){
                Console.WriteLine(val);
            }
        }
    }
}