using ConsoleApp4;
using System.Collections.Generic;

Console.Write("HOW MANY EMPLOYEES WILL BE REGISTERED? ");
int n = int.Parse(Console.ReadLine());
List<employee> funcionarios = new List<employee>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine("EMPLOYEE #" + (i + 1));
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("NAME: ");
    string name = Console.ReadLine();
    Console.Write("SALARY: ");
    double salary = double.Parse(Console.ReadLine());

    funcionarios.Add(new employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("ENTER THE EMPLYEE ID THAT WILL HAVE SALARY INCREASE: ");
int searchid = int.Parse(Console.ReadLine());

employee emp = funcionarios.Find(X => X.Id == searchid);

if (emp != null)
{


    Console.Write("ENTER THE INCREASE PERCENTAGE: ");
    double porcentagem = int.Parse(Console.ReadLine());

    emp.IncreaseSalary(porcentagem);

}
else Console.WriteLine("THIS ID IS NOT VALID!");

Console.WriteLine();
Console.WriteLine("UPDATED LIST OF EMPLOYEES: ");
Console.WriteLine();

foreach (employee obj in funcionarios) Console.WriteLine(obj);