namespace ConsoleApp26_StaticMethods;

public class MyClass
{
    //Static members
    public static string greetings = "Good morning";
    public static int Age { get; set; }
    public static void DisplayAge()
    {
        Console.WriteLine($"Age = {Age}");
    }
   

    //Non-static members
    public string message = "Hello World";
    public string Name { get; set; }
    public void DisplayName()
    {
        Console.WriteLine($"Name is {Name}");
        
    }
}