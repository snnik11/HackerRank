
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> a = [4,6,5,3,3,1];

        int result = Result.pickingNumbers(a);

       Console.WriteLine(result);

    }
    class Result
    {
        public static int pickingNumbers(List<int> a)
        {
            var elementCount = new Dictionary<int, int>();
            foreach (var element in a)
            {
                // Console.WriteLine(element); // 4 6 5 3 3 1
                // Console.WriteLine(elementCount.ContainsKey(element)); // F F F F T F
                if (!elementCount.ContainsKey(element))
                {
                    elementCount.Add(element, 0);
                }

             //   Console.WriteLine(elementCount[element]); //0 0 0 0 1 0
                
                elementCount[element]++; //adds 1,1,1,1,2,1 for 4,6,5,3,3,1
                //Console.WriteLine("new element added ");
              //  Console.WriteLine(elementCount[element]);
              //  Console.WriteLine("end");

                //Console.WriteLine("new ele");
            }

            var max = 0;
            foreach (var key in elementCount.Keys)
            {
                // Console.WriteLine(key); //4 6 5 3 2 1
              //  Console.WriteLine(elementCount.Keys); //System.Collections.Generic.Dictionary`2+KeyCollection[System.Int32,System.Int32]
                var result = elementCount[key];
          //      Console.WriteLine(result); //1 1 1 2 1
                var smallKey = key - 1;
                Console.WriteLine(smallKey); //3 5 4 2 0 3 
                if (elementCount.ContainsKey(smallKey))
                    result += elementCount[smallKey];
                max = Math.Max(max, result);
            }
          //  Console.WriteLine(max);
            return max;

        }





    }
}