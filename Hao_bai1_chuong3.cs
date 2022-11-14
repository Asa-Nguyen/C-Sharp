using System;
class Program{
    static void Main(string[] args){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Tong: "+(a+b));
        Console.WriteLine("Hieu: "+(a-b));
        Console.WriteLine("Tich: "+(a*b));
        if(a%b==0){
            Console.WriteLine("Thuong: "+((float)a/b)+" du 0");
        }else{
            Console.WriteLine("Thuong: "+((float)a/b)+" du "+(a%b));
        }
    }
}