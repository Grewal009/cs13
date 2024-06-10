namespace ConsoleApp26_StaticMethods;

public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public override string ToString()
    {
        return $"FirstName:{FirstName}, LastName:{LastName}";
    }
}