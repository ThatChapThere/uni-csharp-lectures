namespace Week7;

class Student : Person
{
    public string course { get; set; }

    public override void talk()
    {
        Console.WriteLine("Yo");
    }
}