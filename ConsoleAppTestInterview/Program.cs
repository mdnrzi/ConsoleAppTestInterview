// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

var stringTest = File.ReadAllText("C:\\Users\\Win10-Norouzi-L1\\Downloads\\sample.txt");
var employeeModel = JsonConvert.DeserializeObject<List<Employee>>(stringTest);

PrintTopPaid(employeeModel);


//Function for showing 2 top salary person
void PrintTopPaid(List<Employee> employeeModel)
{
    var topSalaries = employeeModel.OrderByDescending(e => e.Salary).Take(2).ToList();
    foreach (Employee employee in topSalaries)
    {
        Console.WriteLine($"name:{employee.Name} - lastName: {employee.LastName}");
    }
}