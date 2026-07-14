Console.WriteLine("Hello, World!");
int[] numbers = { 10, 30, 20, 40, 50 };
Array.Reverse(numbers);
Console.WriteLine(string.Join(", ", numbers));
foreach(int number in numbers)
{
    Console.WriteLine(number);
}
Array.Clear(numbers, 0, numbers.Length);
foreach(int number in numbers)
{
    Console.WriteLine(number);
}