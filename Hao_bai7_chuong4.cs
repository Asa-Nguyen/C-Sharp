using System;
class Program{
    static void Main(string[] args){
        int thang = int.Parse(Console.ReadLine());
        while(thang>12||thang<1){
            Console.WriteLine("Thang khong hop le vui long nhap lai\n");
            thang = int.Parse(Console.ReadLine());
        }
        switch(thang){
            case 1:
                
            
            case 2:
                
            
            case 3:
                Console.WriteLine("Thang "+thang+" thuoc quy 1\n");
            break;
            case 4:
                
            
            case 5:
                
            
            case 6:
                Console.WriteLine("Thang "+thang+" thuoc quy 2\n");
            break;
            case 7:
                
            
            case 8:
                
            
            case 9:
                Console.WriteLine("Thang "+thang+" thuoc quy 3\n");
            break;
            case 10:
                
            
            case 11:
                
            
            case 12:
                Console.WriteLine("Thang "+thang+" thuoc quy 4\n");
            break;
            
        }
    }
}