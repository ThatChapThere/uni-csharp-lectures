internal class Program
{
    static void Main(string[] args)
    {
        // passing parameters by the ref keyword
        int a = 1;
        addOne(ref a);
        Console.WriteLine($"a is now {a}");

        int b;
        createNumber(out b);

        int c = 6;
        printNumber(c);

        Console.WriteLine(getInt("one"));
    }

    static void addOne(ref int n){
        n++;
    }

    static void createNumber(out int n){
        n = 3; // With out, unlike with ref, parameters have to be initialised in order to prevent a warning
        // You usually pass null objects
    }

    static void printNumber(in int n){ // the in keyword passes values by refrence but prevents them from being changed
        // the benefit is performance optimisation for large values like structs
        Console.WriteLine(n);
    }
    List<int> dice = new List<int>{ 1, 2, 3, 4, 5 };

    // examples of defensive programming:

    // guard clauses - if statements that return an error value like -1 or "error" in the case of invalid input
        // eliminate trivial cases
    // we can handle errors in the metehods themselves

    static string parseInput(string input)
    {
        if(input == "")
            return "error - empty string";
        
        return input;
    }

    // exception handling
    // exception handling lets errors get handled by other parts of the code
    // errors can be handled "gracefully"
    // you can also make custom exceptions

    // exceptions can be:
        // dealt with on the spot
        // passed on to be dealt with elsewhere

    // finally might seem redundant, but since try means we don't always return a value but sometimes do,
    // it's useful to have code that runs no matter what

    // only the first catch block is executed even if 
    static int getInt(string s)
    {
        int value;
        try{
            value = int.Parse(s);
        }catch(FormatException){
            Console.WriteLine("invalid value");
            throw; // you can actually type throw on its own in a catch and it throws the caught exception
            // this is called "rethrowing"
        }finally{
            Console.WriteLine("Just cos we returned doesn't mean we're not still going!");
        }
        return value;
    }
}