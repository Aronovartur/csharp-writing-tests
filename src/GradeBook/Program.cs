namespace GradeBook;

internal class Program
{
    private static void Main(string[] args)
    {
        var book = new Book("Scott's Grade Book");
Console.WriteLine("Please enter grades separated by return. enter lowercase \"q\" when done");

var done = false;

while (!done)
{
   var grade = Console.ReadLine();

   if (grade == "q")
   {
       done = true;
       continue;
   }
    book.AddGrade(double.Parse(grade));
}

        book.AddGrade(89.1);
        book.AddGrade(12.3);
        book.AddGrade(23.4);
        var stats = book.GetStatistics();


        Console.WriteLine($"The average grade is: {stats.Average:n1}");
        Console.WriteLine($"The high grade is: {stats.High}");
        Console.WriteLine($"The average grade is: {stats.Low}");
        Console.WriteLine($"The letter grade is: {stats.Letter}");
    }
}