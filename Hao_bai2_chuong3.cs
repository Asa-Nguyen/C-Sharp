using System;
class Program{
    static void Main(string[] args){
        double F = double.Parse(Console.ReadLine());
        double C = ((F-32)*5)/9;
        Console.WriteLine("Nhiet do: "+C+"do C");
    }
}