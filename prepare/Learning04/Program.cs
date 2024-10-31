using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment= new Assignment("Benjamin Nicholas", "Computer Science");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
        MathAssignment mathAssignment= new MathAssignment("Hyrum Rasmussen", "Algebra I", "Section 4.1", "Problems 1-4");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment= new WritingAssignment("Kerrigan Simpson", "Chinese History", "Autumn in the Heavenly Kingdom by Stephen R. Platt");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}