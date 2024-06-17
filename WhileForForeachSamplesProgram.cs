namespace WhileForForeachSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==================================================================================
            //SUMMATION OF ARRAY OF INTEGERS

            int[] numbers = { 100, 200, 300, 400, 500 };
            int total = 0;

            foreach (int i in numbers)
            {
                total += i;

            }
            Console.WriteLine();
            Console.WriteLine("Total number of pre-define array of integer : " + total);

            //=================================================================================

            int[] numbers2 = { 11, 22, 33, 44, 55 };
            int total2 = 0;

            for (int i2 = 0; i2 < numbers2.Length; i2++)
            {

                total2 += numbers2[i2];
            }
            Console.WriteLine();
            Console.WriteLine("Total number of pre-define array of integer : " + total2);

            //==================================================================================

            int[] numbers3 = { 6, 7, 8, 9, 10 };
            int num3 = 0;
            int total3 = 0;

            while (num3 <= numbers3.Length - 1)
            {
                total3 += numbers3[num3];
                num3++;
            }
            Console.WriteLine();
            Console.WriteLine("Total number of pre-define array of integer : " + total3);

            //===================================================================================

        }
    }
    }
