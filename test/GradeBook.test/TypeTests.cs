
namespace GradeBook.test;

public class TypeTests
{
    //whenever you are working with something that has been defined by a class, you are working with a reference type

    class Person
    {
        //any variable that is typed as Person, the value inside of that variable will always be a pointer to some object in memory.  
    }

    public struct Point
    {
        // as special type that needs to behave like a value type, and is very small. struct can have fields, methods but there are special rules.
        
    }
    
    
    [Fact]  
    public void GetBookReturnsDifferentObjects()
    { 
        //set up the test
     var book1 = GetBook("Book 1");
     var book2 = GetBook("Book 2");

     //examine the results against the assertion: expected v actual
     Assert.Equal("Book 1", book1.Name);
     Assert.Equal("Book 2", book2.Name);

    }
    [Fact]
    public void CanSetNameFromReference()
    { 
        //set up the test
        var book1 = GetBook("Book 1");
        SetName( book1, "New Name");
        Assert.Equal("New Name", book1.Name);
        
    }
   [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        var book1 = GetBook("Book 1");
        var book2 = book1;//same pointer VALUE as book1. not a reference to book1
        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1, book2));
    
    }

    [Fact]
    public void Test1()
    {
        var x = GetInt();
        SetInt(x);
        Assert.Equal(3, x);
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        //strings are immutable;

        string name = "Scott";
        var upper = MakeUppercase(name);
        Assert.Equal("SCOTT",upper);
        Assert.Equal("Scott",name);
    }

    public string MakeUppercase(string parameter)
    {
        return parameter.ToUpper();
        
        
    }
    public int GetInt()
    {
        return 3;
    }

 
    public void SetInt(int x)
    {
        x = 42;

        DateTime time = new DateTime();
        
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }

    private void SetName(Book book, string name)
    {
        book.Name = name;
    }
}