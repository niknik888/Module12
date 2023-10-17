static void Greetings()
{
    Console.WriteLine("Как вас зовут?");
    string name = Console.ReadLine();
    string greetings = "Hello, " + name;
    Console.WriteLine(greetings);
}

static void Arr()
{
    Console.WriteLine("Count of elements");
    int count = int.Parse(Console.ReadLine());
    string[] array = new string[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("All elements saved");
}

static void ifelse()
{
    Console.WriteLine("Input age");
    int age = int.Parse(Console.ReadLine());
    if (age > 13)
    {
        Console.WriteLine("Sign up successful");
    }
    else
    {
        Console.WriteLine("Users under the age of 14 cannot be registered");
    }

}