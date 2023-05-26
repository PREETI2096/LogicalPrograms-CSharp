namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isPrime = true;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
           
            for (int i = 2; i <n/2 ; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.Write("Number is Prime.");
        }
    }
}