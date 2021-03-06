namespace Week8;

internal class Program
{
    static void Main(string[] args)
    {
        
    }
}

public abstract class Thing
{
    // private abstract int v; not valid, there is no such thing as abstract fields
    public abstract int value { get; } // only absract classes can have abstract members
    
    public abstract int twiceValue(); // abstract methods are not allowed to be defined
    public virtual int thriceValue() => // virtual methods can have definitions
        value * 3;

    public void test() // normal methods are allowed somehow
    {
        Console.WriteLine(69);
    }
}

public interface IShape
{
    int edges(); // interfaces don't use modifiers, everything is public
    int verteces{ get; } // interfaces may not have fields
}

public class Cube : Thing, IShape
{
    // all abstract properties and methods must be defined in child classes 
    // and use the modifier override

    public override int value
    {
        get => 4;
    }

    public override int twiceValue() =>
        value * 2;

    public int verteces
    {
        get => 8;
    }

    public int edges() => 12;
}

// There are built in interfaces
// like IComparable and IClonable and IEnumerable

// Interfaces are pointed to with dotted arrows in UML