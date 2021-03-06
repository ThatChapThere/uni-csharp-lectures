namespace Week9;

internal class Program
{
    static void Main(string[] args)
    {
        // There are two types of polymorphism
        // Static (comile time) - oveloading functions and operators
        // Dynamic (runtime) Virtual functions


    }
}

public class Adder
{
    // Method overloading
    public static int AddInts(int a, int b) => a + b;
    public static int AddInts(int a, int b, int c) => a + b + c;
}

public class AddableString
{
    public string value{ get; set; }
    public AddableString(string s)
    {
        value = s;
    }

    // Operator overloading - always static for obvious reasons
    // Assignment operators cannot be overloaded in C#
    public static AddableString operator+(AddableString s1, AddableString s2)
    {
        return
            new AddableString(
                (int.Parse(s1.value) + int.Parse(s2.value))
                .ToString()
            );
    }
}

// Dynamic overloading is actually just using virtual/abstract with override