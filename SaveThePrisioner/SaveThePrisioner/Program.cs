namespace SaveThePrisioner
{
    class Result
    {
        public static int LastPrisioner { get; set; }
        public static int saveThePrisoner(int prisoners, int candies, int start)
        {
            for (int i = 0; i < candies; i++)
            {
                if (prisoners == start) start = 1; // row of prisoner reseting one              
                else // All other cases start position increasing 
                {
                  if (i >= 1) start += 1;
                }               
                                                
            }

            return start;
        }

    }
    internal class Solution
    {       
         public static void Main(string[] args)
         {
            Console.WriteLine(Result.saveThePrisoner(6, 8, 5));             
         }            
        
    }
}