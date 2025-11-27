namespace FirstProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Simple exercise 1 ***");
        string[] allOrders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
        
        FaultyOrders.printOrdersForInspection(allOrders);
        
        
        Console.WriteLine("*** More in-depth array processing exercise ***");
        string[] students = ["Sophia", "Andrew", "Emma", "Logan"];
        int[][] allGrades =
        [
            [90, 86, 87, 98, 100],
            [92, 89, 81, 96, 90],
            [90, 85, 87, 98, 68],
            [90, 95, 87, 88, 96]
        ];
        var allStudentsWithScores = new Dictionary<string, int[]>();
        int numStudents = students.Length;
        
        // populate `allScores`
        for (int i = 0; i < numStudents; i++)
        {
            allStudentsWithScores.Add(students[i], allGrades[i]);
        }

        ProcessArrayData.PrintFormattedGradeReport(allStudentsWithScores);
    }
}


