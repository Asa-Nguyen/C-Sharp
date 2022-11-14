using System;
class Program{
    static void Main(string[] args){
        int Toan = int.Parse(Console.ReadLine());
        int Ly = int.Parse(Console.ReadLine());
        int Hoa = int.Parse(Console.ReadLine());
        bool pass = false;
        if(Toan+Ly+Hoa >= 15 && Toan>4&&Ly>4&&Hoa>4)
        {
            pass = true;
        }
        else{
            pass = false;
        }
        if(pass){
            if(Toan>5&&Ly>5&&Hoa>5)
                Console.WriteLine("\nHoc deu cac mon \n");
            else{
                Console.WriteLine("\nHoc chua deu cac mon \n");
            }
        }else{
            Console.WriteLine("\nThi hong\n");
        }
    }
}