using System;
class Program{
    static void Main(string[] args){
        double Toan = double.Parse(Console.ReadLine());
         double Ly = double.Parse(Console.ReadLine());
          double Hoa = double.Parse(Console.ReadLine());
           double dtb = Math.Round((Toan+Ly+Hoa)/3,2);
          Console.WriteLine(dtb);
    }
}