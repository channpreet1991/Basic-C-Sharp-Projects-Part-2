using System;

public class Geometry
{
    // First Constructor
    public string firstConstructor() {
        string type = "First Constructor";
        return type;
    }
    
    // Second Constructor
    public string secondConstructor() {
        string name = "Second Constructor";
        return name;
    }
    
    public static void Main(string[] args)
    {
        // Constant variable
        const double PI = 3.14;
        var text = "Circle";
        
        Geometry s1 = new Geometry();
        
        // Combining both constructors
        Console.WriteLine(s1.firstConstructor());
        Console.WriteLine(s1.secondConstructor());
    }
}