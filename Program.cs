// See https://aka.ms/new-console-template for more information
// created with `dotnet new console -o ./CsharpProjects/TestProject` 

string[] students = ["Sophia", "Nicolas", "Zahirah", "Jeong"];

int studentCount = students.Length;

try
{
    // okay, so to use the debugger - Run and Debug Ctrl + Shift + D, you open the Solution Explorer under the Explorer Tab hhhhhh
    Console.WriteLine("The final name is: " + students[studentCount]);
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.ToString());
}

