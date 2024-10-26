using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Antoine Bonhommer", "Division");
        Console.WriteLine(assignment.getSummary());

        MathAssignment mathAssignment = new MathAssignment("Jeanistine Antoine","Multiplication", "section 7.3", "8-19");
        Console.WriteLine(mathAssignment.getSummary());
        Console.WriteLine(mathAssignment.getHommeWorkList());

        WritingAssignment writingAssignment = new WritingAssignment("Ricarline jean-Baptiste", "Histoire", "L'importance de la ceremonie du bois Caiman dans l'independance d'Haiti");
        Console.WriteLine(writingAssignment.getSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}