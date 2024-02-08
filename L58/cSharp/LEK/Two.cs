
namespace LEK
{
    class Two
    {
        public static void RunAll(){
            Primes();
            Console.WriteLine("alternative: ");
            Console.WriteLine(2);
            Util.Stream.Sequence(3,100,(it) => {if(isPrime(it)) Console.WriteLine(it);});
        }

        private static void Primes(){
            int n = int.Parse(Console.ReadLine());
            int[] primes = new int[n];
            if (n > 1)
            {
                primes[1] = 2;
            }
            for (int i = 3; i <= n; i++)            {
                if(isPrime(i)) primes[i-1] = i;
                i++;
            }
            foreach (var item in primes)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static bool isPrime(int number){
            if (number%2==0) return false;
            int divider = 2;
            for (int i = 3; i < number/divider; i++)
            {
                if (number%i==0) return false;
                divider = i;
                i++;
            }
            return true;
        }
    }
}