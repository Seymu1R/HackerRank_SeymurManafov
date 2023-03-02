namespace GradingStudents
{
    internal class Solution
    {
        public static int[] FinalResults;
        static void Main(string[] args)
        {
            int[] a = { 4, 73, 67, 37, 33, 99 };

            grandingStudents(a);
                  
        }

        public static void grandingStudents(int[] grades) //Method for grading students.
        {
            FinalResults = new int[grades.Length]; //Declare array length and prevent exeption out of bounds

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38) FinalResults[i] = grades[i];  //No change under all conditions under 38.
                
                else if (((grades[i] - grades[i]%5) + 5 - grades[i]) < 3) FinalResults[i] = (grades[i] - grades[i] % 5) + 5; //If number and it's next multiple 5 is difference less than 3, grade is rounded next multiple 5 

                else FinalResults[i] = grades[i];//No changing other cases.                
            }
            foreach (var item in FinalResults)
            {
                Console.WriteLine(item);
            }
        }
    }
}