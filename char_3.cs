using System;
class Program{
    static void Main(string[] args){
        char c = char.Parse(Console.ReadLine());
        if(c>=48&&c<=57)
        {
            Console.WriteLine("Cac ky tu so 0 - 9");
        }
        else if(c>=65&&c<=90)
        {
            Console.WriteLine("Cac ky tu chu hoa A - Z");
        }
        else if(c>=97&&c<=122)
        {
            Console.WriteLine("Cac ky tu chu thuong a - z");
        }
        else{
            Console.WriteLine("Cac ky tu khac");
        }
    }
}