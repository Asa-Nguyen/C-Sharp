using System;
class Program{
    static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        while(n<1||n>100){
            Console.WriteLine("Sai roi, vui long nhap lai trong khoang 1<n<100\n");
            n = int.Parse(Console.ReadLine());
        }if(n % 2 == 0 && n%3==0){
            Console.WriteLine("La so chan chia het cho 3\n");
        }else{
            Console.WriteLine("Khong thoa dieu kien\n");
        }
    }
}