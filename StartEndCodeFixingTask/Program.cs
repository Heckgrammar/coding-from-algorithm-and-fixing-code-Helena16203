namespace StartEndCodeFixingTask
{
    internal class Program
    {
         static void Main(string[] args)
             {
                 // The algorithm in the Readme contains an error
                 // Rewrite the algorithm in C# bellow fixing the error
                 // Show the test outputs for the test table in the Readme
                 // Put your evidence where it says Do the coding task in C#

                 bool validChoice = false;
                 int difference = -1;

                 while (!validChoice)
                 {
                     Console.WriteLine("Enter a start year:");
                     int startYear = Convert.ToInt32(Console.ReadLine());

                     Console.WriteLine("Enter an end year:");
                     int endYear = Convert.ToInt32(Console.ReadLine());

                     if (startYear >= endYear)
                     {
                         Console.WriteLine("Start year must be before end year.");
                         Console.WriteLine("Valid Choice: " + validChoice);
                     }
                     else if (startYear >= 2000)
                     {
                         Console.WriteLine("Start year must be before 2000.");
                         Console.WriteLine("Valid Choice: " + validChoice);
                     }
                     else
                     {
                         validChoice = true;
                         difference = endYear - startYear;
                         Console.WriteLine("Valid Choice: " + validChoice);
                     }
                 }
                 Console.WriteLine("Difference: " + difference);
             }
        }
}
