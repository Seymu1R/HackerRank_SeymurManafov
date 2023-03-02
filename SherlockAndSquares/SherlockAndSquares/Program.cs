namespace SherlockAndSquares
{
    class Result
    {
        public static double Sqrt { get; set; }
        public static int Count { get; set; }
        public static int Step { get; set; }

        public static void squares(int a, int b)
        {
            Step = a; //Decleare step 

            for (int i = 0; i < (b-a) + 1; i++) // Lopping difference entered number.
            {
                Sqrt = Math.Sqrt(Step); // Square root of Step

                if (Sqrt % 1 == 0) // check Square root is integer
                {
                    Count ++; // increase count of Square roots
                }

                Step++;
            }

            Console.WriteLine(Count);
        }

    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            Result.squares(3, 9);
        }
    }
}