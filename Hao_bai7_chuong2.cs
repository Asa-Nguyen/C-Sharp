using System;
class Program{
     static void Main(string[] args){
        char c = Convert.ToChar(Console.ReadLine());
        byte ascii = (byte)c;
        Console.WriteLine(ascii);
        c++;
        Console.WriteLine(c);
     }
     
}