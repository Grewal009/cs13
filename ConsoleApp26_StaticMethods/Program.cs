// See https://aka.ms/new-console-template for more information

using ConsoleApp26_StaticMethods;

Student.PrintSchool();
Student s1 = new Student("Jas",01);
s1.StudentInfo();

Console.WriteLine(s1.CalculateSum(2,3));

Person person = new Person { FirstName = "Sam", LastName = "Musk"};
Console.WriteLine(person);
// person.FirstName = "xyz"; // error
Console.WriteLine(person.FirstName);