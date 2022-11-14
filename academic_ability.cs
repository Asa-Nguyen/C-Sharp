using System;
class Program{
    static void Main(string[] args){
        int dtb = int.Parse(Console.ReadLine());
        if(dtb>=0 && dtb <3){
            Console.WriteLine("Kem");
        }else if(dtb>=3&&dtb<5)
        {
            Console.WriteLine("Yeu");
        }
        else if(dtb>=5&&dtb<6.5)
        {
            Console.WriteLine("Trung binh");
        }else if(dtb>=6.5&&dtb<8)
        {
            Console.WriteLine("Kha");
        }
        else if(dtb>=8&&dtb<9)
        {
            Console.WriteLine("Gioi");
        }else if(dtb>=9&&dtb<=10)
        {
            Console.WriteLine("Xuat Sac");
        }
    }
}