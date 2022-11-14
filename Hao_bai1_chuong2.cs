using System;
class Program{
   static void Main(string[] args){
        double pi = 3.141;
        double r = double.Parse(Console.ReadLine());
        double chu_vi = 2*r*pi;
        double dien_tich = r*r*pi;
        Console.WriteLine("Chu vi: "+chu_vi);
        Console.WriteLine("Dien tich: "+dien_tich);
   }
}