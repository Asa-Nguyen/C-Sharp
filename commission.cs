using System;
class Program{
    static void Main(string[] args){
        int sale1 = int.Parse(Console.ReadLine());
        int sale2 = int.Parse(Console.ReadLine());
        int commissionRate = int.Parse(Console.ReadLine());
        int totalSale = sale1 + sale2 ;
        int commission = totalSale*commissionRate;
        Console.WriteLine(commission);
    }
}