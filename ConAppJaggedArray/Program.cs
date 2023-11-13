using System;

class ConAppJaggedArray
{
    static void Main()
    {
        // Create a jagged array to store scores of three students
        int[][] studentScores = new int[3][];

        // Initialize the jagged array with scores for each student
        studentScores[0] = new int[] { 85, 92, 78 };
        studentScores[1] = new int[] { 90, 87, 93, 89 };
        studentScores[2] = new int[] { 76, 88 };

        // Print the scores of each student using nested loops
        Console.WriteLine("Scores of each student:");
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write(studentScores[i][j] + " ");
            }
            Console.WriteLine();
        }

        // Calculate and print the average score for each student
        Console.WriteLine("\nAverage score for each student:");
        for (int i = 0; i < studentScores.Length; i++)
        {
            double average = CalculateAverage(studentScores[i]);
            Console.WriteLine($"Student {i + 1}: {average:F2}");
        }

        // Calculate and print the average score for all students combined
        double overallAverage = CalculateOverallAverage(studentScores);
        Console.WriteLine($"\nAverage score for all students combined: {overallAverage:F2}");

        Console.ReadKey(); // Keep the console open until a key is pressed
    }

    // Helper method to calculate the average of an array of scores
    static double CalculateAverage(int[] scores)
    {
        if (scores.Length == 0)
        {
            return 0; // To avoid division by zero
        }

        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }

        return (double)sum / scores.Length;
    }

    // Helper method to calculate the overall average of all students
    static double CalculateOverallAverage(int[][] studentScores)
    {
        int totalScores = 0;
        int totalStudents = 0;

        foreach (int[] scores in studentScores)
        {
            totalScores += scores.Length;
            totalStudents += scores.Length; // Increment totalStudents by the number of scores in each student
        }

        if (totalStudents == 0)
        {
            return 0; // To avoid division by zero
        }

        return (double)totalScores / totalStudents;
    }
}




