namespace ClimbingTheLeaderboard
{
    class Result
    {
        public static int[] ResultRanking { get; set; }
        public static void  climbingLeaderboard(int [] rankeds, int [] players)
        {
            ResultRanking = new int[players.Length];// Declaring ResultRanking Array length
            
            for (int i = 0; i < players.Length; i++)
            {
                for (int j = 0; j < rankeds.Length; j++)
                {
                    if (players[i] < rankeds[rankeds.Length - 1]) // If player's rank is smaller all rank, player ranked last rank  
                    {
                        ResultRanking[i] = rankeds.Length + 1;
                    }
                    if(rankeds.Length - (j + 2) >= 0) // All of the other case 
                    {
                        if (players[i] >= rankeds[rankeds.Length - (j + 1)] && players[i] < rankeds[(rankeds.Length - (j + 2))])
                        {
                            ResultRanking[i] = rankeds.Length - (j + 1) + 1;
                        }
                    }
                    if (players[i] > rankeds[0])// If player's rank is bigest all rank, player ranked first rank
                    {
                        ResultRanking[i] = 1;
                    }
                    
                }       
             

            }
            foreach (var item in ResultRanking)
            {
                Console.WriteLine(item);
            }
        }

    }
    internal class Program
    {
        public static void Main(string[] args)
        {        

            int[] rankeds = { 100, 90,80, 50 };
            int[] players = {70,80,90, 105, 40 };

            Result.climbingLeaderboard(rankeds, players);         
        }
    }
}