namespace Week_6;

internal class Program
{
    static void Main(string[] args)
    {
        // Collections are like arrays
        // but arrays have a fixed size
        // while collections have a variable size

        // Collections have a set of functions usefult for manipluating data

        // Collections are a class
        // They have a generic type and so use <T>

        List<int> ints = new List<int>() { 1, 2 };

        ints.Add(3);

        Console.WriteLine($"List has length {ints.Count}");
        Console.WriteLine($"List has maximum possible length {ints.Capacity}");

        ints.Remove(1); // removes the number 1
        ints.RemoveAt(0); // removes the first item in the list


        List<CustomClass> customList = new List<CustomClass>() { new CustomClass(2) };

        // CustomClass f;
        // customList.Append(f);
        //  ^ every instance of a class in a collection must be initialised - so this is invalid

        // Stacks

        Stack<int> stack = new Stack<int>();

        stack.Push(3);
        stack.Push(2);

        Console.WriteLine($"The value at the top of the stack is {stack.Pop()}");
        Console.WriteLine($"The value at the top of the stack is {stack.Peek()}");
        Console.WriteLine($"The value at the top of the stack is {stack.Peek()}");

        Queue<int> queue = new Queue<int>();

        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine($"The value at the front of the queue is {queue.Dequeue()}");
        Console.WriteLine($"The value at the front of the queue is {queue.Peek()}");
        Console.WriteLine($"The value at the front of the queue is {queue.Peek()}");

        Dictionary<string, int> pets = new Dictionary<string, int>();

        pets.Add("cats", 3);
        pets.Add("dogs", 56);

        Console.WriteLine($"Are there any mice? {pets.ContainsKey("mice")}");
        Console.WriteLine($"Are there 56 of any pet? {pets.ContainsValue(56)}");
        Console.WriteLine($@"Are there 3 cats? {
            pets.Contains(
                new KeyValuePair<string, int>("cats", 3)
            )
        }");

        // LINQ (language integrated query)

        // There are two syntaxes: lambda syntax and query syntax

        var numerousPets = pets.Where(p => p.Value > 10);
        var numerousPetNames = from pet in pets
            where pet.Value > 10
            select pet.Key;
    }
}
