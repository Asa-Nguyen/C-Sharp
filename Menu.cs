using System;
class Program{
    static void Main(string[] args){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while(true){
            Console.WriteLine("|----------MENU----------|");
            Console.WriteLine("|1.Tinh tong             |");
            Console.WriteLine("|2.Tinh hieu             |");
            Console.WriteLine("|3.Tinh tich             |");
            Console.WriteLine("|4.Tinh thuong           |");
            Console.WriteLine("|------------------------|\n");
            int lua_chon = int.Parse(Console.ReadLine());
            switch(lua_chon){
                case 1:
                    Console.WriteLine(a+b);
                break;
                case 2:
                    Console.WriteLine(a-b);
                break;
                case 3:
                    Console.WriteLine(a*b);
                break;
                case 4:
                    if(b!=0)
                        Console.WriteLine((float)a/b);
                    else{
                        Console.WriteLine("Khong chia duoc");
                    }
                break;
                default:
                    Console.WriteLine("Khong co trong menu !! ");
                break;
            }
        }
    }
}