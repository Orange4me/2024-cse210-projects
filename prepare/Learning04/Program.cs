using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assignment1 = new Assignment();
        Assignment1.SetStudentName("Jim");
        Assignment1.SetTopic("Spanish");

        Console.WriteLine(Assignment1.GetSummary());

        MathAssignment Assignment2 = new MathAssignment();
        Assignment2.SetStudentName("Paul");
        Assignment2.SetTopic("Mathematics");
        Assignment2.SetTextbookSelection("Section 7.2");
        Assignment2.SetProblems("5-25 odd numbers");

        Console.WriteLine(Assignment2.GetHomeworkList());

        WritingAssignment Assignment3 = new WritingAssignment();
        Assignment3.SetStudentName("Sarah");
        Assignment3.SetTopic("English");
        Assignment3.SetTitle("Persuasion");

        Console.WriteLine(Assignment3.GetWritingInformation());
    }
}