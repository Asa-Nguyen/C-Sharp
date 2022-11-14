using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Nhap a va b voi phuong trinh bac nhat ax + b = 0 \n");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if(a==0){
            if(b==0){
                Console.WriteLine("\nVo so nghiem \n");
            }else{
                Console.WriteLine("\nVo nghiem\n");
            }
        }else{
            Console.WriteLine("Co nghiem x = " + (float)-b/a);
        }
    }
}