using System.Reflection.Metadata.Ecma335;

namespace BrithDayCakesCandles
{   
    class Result
    {
        public static int MaxBrithdayCandle { get; set; }
        public static int Count { get; set; }

        public static void birthdayCakeCandles(int[] candles) 
        {
            MaxBrithdayCandle = candles[0]; // Declare MaxBrithdayCandle one of candles.

            for (int i = 0; i < candles.Length; i++) // Looping candles 
            {
               if( MaxBrithdayCandle <= candles[i]) MaxBrithdayCandle = candles[i]; //MaxBrithdayCandle is equal to the biggest one
            }

            for (int i = 0; i < candles.Length; i++)
            {
                if(MaxBrithdayCandle == candles[i]) Count++; // when maxBrithdayCandle is more than one incresing count.           
            }
            Console.WriteLine(Count);
        }

    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            int[] a = { 5,33,6,33,33,20,33};
            Result.birthdayCakeCandles(a);
        }
    }
}