namespace Week7;

internal class Program
{
    static void Main(string[] args)
    {
        // Inheritance

        // UML diagrams are the standard for class diagrams
        // Arrows go from child to parent (confusingly?)

        // Depending on access modifiers, methods and valued from the parent can be accessed by child classed

        // Constructors and Finalisers are not inherited
        // Private variables are not inherited 
        // Protected variables are, but are still not public

        // You can also make sealed classes and these cannot be inheritated from


        // When a child class is made, the object is formed in the following order:
            // Child initialisers
            // Parent initialisers
            // Parent constructor
            // Child constructor
        
        // you can make virtual methods and override them
        new Student();
    }
}
