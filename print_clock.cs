using System;
class Program{
    static void Main(string[] args){
        int gio, phut,giay;
        int soGiay = int.Parse(Console.ReadLine());
        gio = soGiay/3600;
        phut = (soGiay % 3600)/60;
        giay = soGiay % 60;  
        if(gio<10&&phut<10&&giay<10)
        {
            Console.WriteLine("0"+gio+":"+"0"+phut+":"+"0"+giay);
        }
        else if(gio<10&&phut<10)
        {
            Console.WriteLine("0"+gio+":"+"0"+phut+":"+giay);
        }
        else if(phut<10&&giay<10)
        {
            Console.WriteLine(gio+":"+"0"+phut+":"+"0"+giay);
        }
        else if(gio<10)
        {
            Console.WriteLine("0"+gio+":"+phut+":"+giay);
        }
        else if(phut<10)
        {
            Console.WriteLine(gio+":"+"0"+phut+":"+giay);
        }
        else if(phut<10)
        {
            Console.WriteLine(gio+":"+phut+":"+"0"+giay);
        }
        
    }
}