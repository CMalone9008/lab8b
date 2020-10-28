using System;
class employee
{
private string firstName;
private string lastName;
private string id;
private int age;
private string address;
private string phoneNumber;
private string title;
private double salary;
private string employmentStatus;
private double percent;
  

public employee()
{
  firstName = "unknown";
  lastName = "unknown";
  id = "unknown";
  age = 0;
  employmentStatus = "active";
  address = "unknown";
  phoneNumber = "unknown";
  title = "unknown";
  
  
}
public employee(string name1, string name2, int age1, string id1, double salary1, string employmentStatus1)
{
  firstName = name1;
  lastName = name2;
  id = id1;
  if (age1 > 18 && salary1 > 1000)
  {
    age = age1;
    salary = salary1;
  }
  else 
  {
    age = 18;
    salary = 1000;
  }
  employmentStatus = employmentStatus1;
  

}
public void intro()
{
  Console.WriteLine("First name " + firstName);
  Console.WriteLine("Last name: " + lastName);
  Console.WriteLine("Age: " + age);
  Console.WriteLine("Id: " + id);
  Console.WriteLine("Salary: " + salary);
  Console.WriteLine("Employment Status: " + employmentStatus);
}
public void increasedSalary(double percent1)
{
if (percent1 > .0)
{ 
double increase = salary * percent1;
Console.WriteLine("Yearly salary updated: " + (salary + increase));
}
else
{
  Console.WriteLine("Invalid input");
}

}
public void removeEmployee()
{
if(employmentStatus == "inactive")
{
  Console.WriteLine("Employee already inactive");
}
else
{
  employmentStatus = "active";
  Console.WriteLine("Employee removed successfully");
}

}

}