using System;

// Function Overloading Example
public class Calculator
{
    // Overloaded method with two integer parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with two double parameters
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Overloaded method with two string parameters
    public string Add(string a, string b)
    {
        return a + b;
    }
}

// Function Overriding Example
public class Shape
{
    // Virtual method in the base class
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    // Override the Draw method in the derived class
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        // Function Overloading
        Calculator calculator = new Calculator();
        int sumInt = calculator.Add(5, 10);
        double sumDouble = calculator.Add(5.5, 10.5);
        string concatenatedString = calculator.Add("Hello", " World");

        Console.WriteLine($"Function Overloading Results:\nSum (int): {sumInt}\nSum (double): {sumDouble}\nConcatenation: {concatenatedString}\n");

        // Function Overriding
        Shape shape = new Circle(); // Creating an instance of the derived class
        shape.Draw(); // Calls the overridden Draw method in the Circle class
    }
}
