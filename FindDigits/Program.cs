internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("new");
        // Console.WriteLine(2% 12);  //2 
        //Console.WriteLine(2 / 12); //0

        Console.WriteLine(124 % 10);
        Console.WriteLine(124 / 10);

        int result = Result.findDigits(12);

            Console.WriteLine(result);
        
    }
    class Result
    {

        /*
         * Complete the 'findDigits' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int findDigits(int n)
        {
            var result = 0;
            var intVal = n;

            while (intVal != 0) 
            {
                var remainder = intVal % 10;
                if (remainder != 0 && n % remainder == 0)
                    result++;
                    intVal /= 10;
            }
            return result;

                       
        }

    }
}