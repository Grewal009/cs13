
namespace ConsoleApp26_StaticMethods;

public class Student
{
    public string Name;
    public int RollNo;
    public static string School = "BR";

    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
    }

    public static void PrintSchool() => Console.WriteLine($"School Name is {Student.School}");

   public void StudentInfo()
   {
       Console.WriteLine($"Name:{Name}, Rollno:{RollNo}, School:{GetSchool()}");

       static string GetSchool()
       {
           return School;
       }
   }
   
       public int CalculateSum(int a, int b)
       {
           return Add(a, b);

           static int Add(int x, int y)
           {
               return x + y;
           }
       }
   


}