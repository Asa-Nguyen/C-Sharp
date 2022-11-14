using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Nhap x1: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap y1: ");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap x2: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap y2: ");
        int y2 = int.Parse(Console.ReadLine());
        double f1 = (double) (y2-y1)*(y2-y1);
        double f2 = (double) (x2-x1)*(x2-x1);
        double kq = Math.Sqrt(f1+f2);
        Console.WriteLine("Ket qua: "+kq);
    }
}