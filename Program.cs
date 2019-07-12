using System;

namespace EmployeeList
{
  class Program
  {
    static void Main(string[] args)
    {
      Company NSS = new Company()
      {
        Name = "Nashville Software School",
        DateFounded = new DateTime(2012, 6, 22)
      };

      NSS.AddEmployee(new Employee()
      {
        FirstName = "Adam",
        LastName = "Sheaffer",
        Title = "Mr."
      });

      NSS.AddEmployee(new Employee()
      {
        FirstName = "Brenda",
        LastName = "Long",
        Title = "Ms."
      });

      NSS.AddEmployee(new Employee()
      {
        FirstName = "John",
        LastName = "Wark",
        Title = "Mr."
      });

      NSS.PrintEmployees();

    }
  }
}
