using System;
class Program{
    static void Main(string[] arg)
    {
        int thang = int.Parse(Console.ReadLine());
        int nam = int.Parse(Console.ReadLine());
        int ngay;
        while(thang<1||thang>12||nam<1){
            Console.WriteLine("thang hoac nam khong hop le vui long nhap lai");
            thang = int.Parse(Console.ReadLine());
            nam = int.Parse(Console.ReadLine());
        }
        if((thang==1)||(thang == 3)||(thang == 5)||(thang==7)||(thang==8)||(thang==10)||(thang==12)){
            ngay = 31;
            Console.WriteLine("Thang " + thang + " nam " + nam + " co " + ngay + "ngay");
        }
        else if((thang==4)||(thang==6)||(thang==9)||(thang==11)){
            ngay = 30;
            Console.WriteLine("Thang " + thang + " nam " + nam + " co " + ngay + "ngay");
        }else{
            if(((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0)){
                     ngay = 29;
                     Console.WriteLine("Thang " + thang + " nam " + nam + " co " + ngay + " ngay ");
                 }
        }
    
}
}
