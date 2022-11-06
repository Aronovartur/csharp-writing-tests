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

   try
   {
       book.AddGrade(double.Parse(grade));
   }
   catch (Exception e)
   {
       Console.WriteLine("Please enter numeric numbers only. no letters, except \"q\" to quit");
       continue;
   }
    
}
      var stats = book.GetStatistics();


        Console.WriteLine($"The average grade is: {stats.Average:n1}");
        Console.WriteLine($"The high grade is: {stats.High:n1}");
        Console.WriteLine($"The low grade is: {stats.Low:n1}");
        Console.WriteLine($"The letter grade is: {stats.Letter}");
    }
}