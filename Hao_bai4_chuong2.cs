using System;
class Program{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int temp = num1;
    num1 = num2;
    num2 = temp;
    Console.WriteLine(num1);
    Console.WriteLine(num2);
}