namespace GradeBook
{
   
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Scott's Grade Book");

            book.AddGrade(89.1);
            book.AddGrade(12.3);
            book.AddGrade(23.4);
            var stats = book.GetStatistics();
            

            Console.WriteLine($"The average grade is: {stats.Average:n1}");
            
            Console.WriteLine($"The high grade is: {stats.High}");
            
            Console.WriteLine($"The average grade is: {stats.Low}");
        }
    }
    
}
