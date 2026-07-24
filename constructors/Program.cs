using constructors;

BankAccount1 account = new BankAccount1();
account.showdetails();

Console.WriteLine("===Constructor overloading output===");
BankAccount accountt1 = new BankAccount();
accountt1.ShowDetails();


BankAccount accountt2 = new BankAccount("Marky");
accountt2.ShowDetails();


BankAccount accountt3 = new BankAccount("Marky",200);
accountt3.ShowDetails();


Console.WriteLine("===static constructor===");
Bankaccount acc1 = new Bankaccount();
Bankaccount acc2 = new Bankaccount();

Console.WriteLine("===Destructors===");
Bankaccc acc3 = new Bankaccc();


//Console.WriteLine("===fields and properties===");
//cms std = new cms();
//std.Name = "Marky";
//std.Age = -20;
//Console.WriteLine($"student name is {std.Name} and age is {std.Age}");

Console.WriteLine("===fields and properties===");
BankAtmSystem khata = new BankAtmSystem("5055050250505","Marky",-5000000);
khata.ShowBalance();