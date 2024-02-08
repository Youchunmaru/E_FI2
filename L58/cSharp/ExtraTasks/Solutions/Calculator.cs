namespace ExtraTaskSolutions
{
    class Calculator
    {
        public static void RunAll(){
            /*
            ### 1.1
            */
            Console.WriteLine("How many number would you like to add?");
            int addN = int.Parse(Console.ReadLine());
            int[] addNumbers = new int[addN];
            int index = 1;
            while (addN > 0)
            {
                Console.WriteLine(index++);
                addNumbers[index-1] = int.Parse(Console.ReadLine());
                addN--;
            }
            int sum = 0;
            while (index > 0)
            {
                sum += addNumbers[index-1];
            }
            Console.WriteLine($"The solution is {sum}");
            /*
            ### 1.2
            *//*
            Console.WriteLine("How many number would you like to add?");
            int subN = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int index = 1;
            while (n > 0)
            {
                Console.WriteLine(index++);
                numbers[index-1] = int.Parse(Console.ReadLine());
                n--;
            }
            int sum = 0;
            while (index > 0)
            {
                sum += numbers[index-1];
            }
            Console.WriteLine($"The solution is {sum}");*/
        }
    }
}