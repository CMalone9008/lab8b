using System;

class MainClass {
  public static void Main (string[] args) {
    
    employee newEmployee1 = new employee();
    newEmployee1.intro();
    employee newEmployee2 = new employee("Robert","Downey", 18, "12321", 1000, "inactive");
    newEmployee2.intro();
    newEmployee2.removeEmployee();
    employee newEmployee3 = new employee("John", "Smith", 38, "S0089", 50000, "active");
    newEmployee3.intro();
    newEmployee3.increasedSalary(-.02);
    newEmployee3.removeEmployee();
    employee newEmployee4 = new employee("Maria", "Lambert",26, "S0010", 80000, "active");
    newEmployee4.intro();
    newEmployee4.increasedSalary(.07);
    newEmployee4.removeEmployee();

  }
}