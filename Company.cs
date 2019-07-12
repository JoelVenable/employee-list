using System;


namespace EmployeeList
{
  public class Company
  {
    public DateTime DateFounded { get; set; }
    public string Name { get; set; }

    private List<Employee> _employeeList = new List<Employee>();

    public void PrintEmployees()
    {
      _employeeList.ForEach(employee =>
      {
        System.Console.WriteLine($"Employee: {employee}");
      });
    }


    public void AddEmployee(Employee newEmployee)
    {
      _employeeList.Add(newEmployee);
    }
  }
}