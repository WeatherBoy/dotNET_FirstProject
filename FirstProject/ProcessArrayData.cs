namespace FirstProject;

public static class ProcessArrayData
{
    
    private static string GetLetterGrade(decimal averageGrade)
    {
        switch (averageGrade)
        {
            case >= 97.0m:
                return "A+";
            case >= 93.0m:
                return "A";
            case >= 90.0m:
                return "A-";
            case >= 87.0m:
                return "B+";
            case >= 83.0m:
                return "B";
            case >= 80.0m:
                return "B-";
            case >= 77.0m:
                return "C+";
            case >= 73.0m:
                return "C";
            case >= 70.0m:
                return "C-";
            case >= 67.0m:
                return "D+";
            case >= 63.0m:
                return "D";
            case >= 60.0m:
                return "D-";
            case >= 0:
                return "F";
            default:
                return "Something went wrong in the grading :/";
        }
    }
    
    // just for decoration
    private static decimal GetMean(int[] grades)
    {
        /*
         * Alternatively:
         * int n = grades.Length;
         * int total = grades.Sum();
         * decimal mean = (decimal)total / n;
         *
         * return mean;
         */
        return (decimal)grades.Sum() / grades.Length;
    }

    public static void PrintFormattedGradeReport(Dictionary<string, int[]> allStudentsWithScores)
    {
        Console.WriteLine("Student\t\tGrade\n");
        foreach ((string student, int[] grades) in allStudentsWithScores)
        {
            decimal averageGrade = (decimal)grades.Average();
            string letterGrade = GetLetterGrade(averageGrade);
            
            Console.WriteLine($"{student}:\t\t{averageGrade}\t{letterGrade}");
        }
    }
}