namespace Week7;

class Person
{
    public string name { get; set; }
    public int age { get; set; }

    public virtual void talk()
    {
        Console.WriteLine("Hello");
    }
}