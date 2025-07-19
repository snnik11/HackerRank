namespace Recursive_Digit_Sum
{
    public class RecDigitSum
    {

        /*
         * Complete the 'superDigit' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING n
         *  2. INTEGER k
         */

        public  int superDigit(string n, int k)
        {
            long initialSum = 0;
            foreach (char c in n)
            {
                initialSum += c - '0';
            }

            long total = initialSum * k;
            Console.WriteLine(FindSum(total));
            return FindSum(total);
        }
        public int FindSum(long num)
        {
            if (num < 10)
            {
                return (int)num;
            }
            long sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return FindSum(sum);
        }

    }
}
