using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Nhap gio: ");
        int gio = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap phut: ");
        int phut = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap giay: ");
        int giay = int.Parse(Console.ReadLine());
        
        while(gio>24||phut>60||giay>60){
            Console.WriteLine("Nhap sai roi vui long nhap lai: ");
            gio = int.Parse(Console.ReadLine());
            phut = int.Parse(Console.ReadLine());
            giay = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Nhap so giay them vao ");
        int giay_them = int.Parse(Console.ReadLine());
        giay+=giay_them;
        if(giay>=60)
        {
            phut += 1;
            giay = giay - 60;
        }
        if(phut>=60){
            gio+=1;
            phut = phut - 60;
        }if(gio>=24){
            gio = gio -24;
        }
        if(gio<10&&phut<10&&giay<10)
            Console.WriteLine("0"+gio+":"+"0"+phut+":"+"0"+giay);
        else if(gio<10&&phut<10)
            Console.WriteLine("0"+gio+":"+"0"+phut+":"+giay);
        else if(phut<10&&giay<10)
            Console.WriteLine(gio+":"+"0"+phut+":"+"0"+giay);    
        else if(gio<10&&giay<10)
            Console.WriteLine("0"+gio+":"+phut+":"+"0"+giay);    
        else if(gio<10){
            Console.WriteLine("0"+gio+":"+phut+":"+giay);
        }
        else if(phut<10){
            Console.WriteLine(gio+":"+"0"+phut+":"+giay);
        }
        else if(phut<10){
            Console.WriteLine(gio+":"+phut+":"+"0"+giay);
        }
    }   
}