namespace GradeBook;

public class Book
{
    //define fields

    private List<double> grades;

    public string Name;
    //use constructor to initialize fields
    public Book(string name)
    {
         grades = new List<double>();
         Name = name;
    }
     
    // private double average = 0;
     
    public void AddGrade(double grade)
    {
         grades.Add(grade);
    }

    public double GetAverage()
    {
        return grades.Average();
    }

    public double GetMin()
    {
        return grades.Min();
    }

    public double GetMax()
    {
        return grades.Max();
    }

    public Statistics GetStatistics()
    {
        var result = new Statistics();
        result.Average = 0.0;
        result.High = 0.0;
        result.Low = 0.0;

        result.Average = GetAverage();
        result.Low = GetMin();
        result.High = GetMax();

        return result;
    }
}