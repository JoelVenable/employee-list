using System;


namespace EmployeeList
{
  public class Employee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }

    public string TitleFullName
    {
      get
      {
        return $"{Title} {FirstName} {LastName}";
      }
    }

    public DateTime StartDate { get; set; }

  }
}