using System;
class Program{
    static void Main(string[] args){
        char c = char.Parse(Console.ReadLine());
        if(c=='r' || c=='R'){
            Console.WriteLine("RED");
        }
        else if(c=='g'||c=='G'){
            Console.WriteLine("GREEN");
        }
        else if(c=='b'||c=='B'){
            Console.WriteLine("BLUE");
        }else{
            Console.WriteLine("BLACK");
        }
    }
}