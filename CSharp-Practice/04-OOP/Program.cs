//classes and objects practice

//access modifier
using System;
using System.Diagnostics;

//BankAccount
//│
//├── private balance
//├── Deposit()
//├── Withdraw()
//└── ShowBalance()

//class BankAccount
//{
//    private double balance;

//    public void Deposit(double amount)
//    {
//        if (amount > 0)
//        {
//            balance += amount;
//            Console.WriteLine($"{amount} deposited in the bank acc");
//        }
//        else
//        {
//            Console.WriteLine("cant deopist the amount less then 0");
//        }
//    }

//    public void WithDrawl(double amount)
//    {
//        if( balance < amount)
//        {
//            Console.WriteLine("The amount cant be withdrawl as it is more than the bank baalnce itself");
//        }
//        else
//        {
//            balance -= amount;
//            Console.WriteLine($"{amount} from your bank balance");
//        }
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine($"{balance} is the current bank balance");
//    }

//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        BankAccount account= new BankAccount();
//        account.Deposit(5000);
//        account.WithDrawl(2000);
//        account.ShowBalance();
//        //account.balance = 5000; not possble because accessing the private data members is not possible outside of the class 
//    }
//}


//Create a C# program to manage employees.

//Requirements

//Create a class named Employee with the following members:

//private double salary
//protected string department
//public string Name

//Create the following methods:

//SetSalary(double amount) → Sets the salary if it is greater than 0.
//ShowSalary() → Displays the salary.

//Now create another class named Manager that inherits from Employee.

//Inside the Manager class:

//Assign "IT Department" to department.
//Create a method ShowDepartment() that displays the department.

//In Main():

//Create a Manager object.
//Set the manager's name.
//Set the salary.
//Display the salary.
//Display the department.

//Finally, try accessing salary and department directly from Main() and observe the errors.

using System;
class Employee
{
    private double salary;

    protected string department;

    public string name;

    public void SetSalary(double amount)
    {
        if (amount > 0)
        {
            salary = amount;
            Console.WriteLine("salary assigneed succesfully!!!!!!");
        }
        else
        {
            Console.WriteLine("Amount smaller then or equal  cant be assigned as salary");
        }
    }
    public void ShowSalary()
    {
        Console.WriteLine($"{salary} is the salary amount assigned  ");
    }
}
class Manager : Employee
{
    public Manager()
    {
        department = "IT Department";
    }
    public void ShowDepartment()
    {
        Console.WriteLine($"The name of the department is:{department}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Manager emp = new Manager();
        emp.name = "marky";
        Console.WriteLine($"The name of the manager is {emp.name}");
        emp.SetSalary(50000);
        emp.ShowSalary();
        emp.ShowDepartment();
        //emp.department = 5000;
        //emp.salary=20000;
    }
}
