//Hands on Array

using System.Diagnostics.CodeAnalysis;

var numbers = new[] { 10, 20, 40, 50, 30 };
Console.WriteLine(Array.IndexOf(numbers, 50));

bool found = Array.Exists(numbers, x => x == 20+2);
Console.WriteLine(found);

//multidimensional array
var number1 = new[,]
{
    {10,20,30 },
    {40,50,60 },
    {70,80,90 }
};

Console.WriteLine(number1.Rank);

int[,] matrix = { 
    { 10,20,30},
    { 40,50,60}
    };
//Console.WriteLine(matrix[2, 2]);

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j= 0;j<matrix.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i, j]+ " ");
    }
}
Console.WriteLine("so this below is printed using foreach looping statement");

foreach(int m in matrix)
{
    Console.WriteLine(m + " ");
}