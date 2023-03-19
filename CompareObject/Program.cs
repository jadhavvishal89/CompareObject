// See https://aka.ms/new-console-template for more information
using CompareObject;

Console.WriteLine("Welcon to Object equale check!\n");
Students student1 = new Students { studentid = 1, name = "vishal" };
Students student2 = new Students { studentid = 1, name = "vishal" };
Console.WriteLine("Compare student1 and student2 object\n");
Console.WriteLine("student1 and student2 object ="+ student1.Equals(student2) +"\n");

Students student3 = new Students { studentid = 2, name = "vishal2" };
Console.WriteLine("student1 and student3 object =" + student1.Equals(student3));
