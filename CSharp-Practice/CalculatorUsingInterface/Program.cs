using CalculatorUsingInterface;

IOperation add = new Add();
Console.WriteLine(add.Calculate(5, 6));

IOperation sub = new Subtract();
IOperation mul = new Multiply();
IOperation div = new Divide();

Console.WriteLine(sub.Calculate(5, 3));
Console.WriteLine(mul.Calculate(5, 3));
Console.WriteLine(div.Calculate(5, 3));

