using System;
class Program{
    static void Main(string[] args){
        int chi_so_cu = int.Parse(Console.ReadLine());
        int chi_so_moi = int.Parse(Console.ReadLine());
        int chi_so = chi_so_moi - chi_so_cu;
        int vuot_dinh_muc = chi_so - 50;
        int gia;
        if(vuot_dinh_muc<=0){
            gia = 1000;
            int tien = chi_so*gia;
            Console.WriteLine("So tien phai tra: "+tien);
        }
        if(vuot_dinh_muc>0&&vuot_dinh_muc<=50){
            gia = 1500;
            int tien = 50*1000 + 1500*vuot_dinh_muc;
            Console.WriteLine("So tien phai tra: "+tien);
        }
        if(vuot_dinh_muc>50&&vuot_dinh_muc<=100){
            gia = 1800;
            int tien = 50*1000 + 1500*50 + 1800*(vuot_dinh_muc-50);
            Console.WriteLine("So tien phai tra: "+tien);
        }
        if(vuot_dinh_muc>100){
            gia = 2500;
            int tien = 50*1000 + 1500*50 + 1800*50 + 2500*(vuot_dinh_muc-100);
            Console.WriteLine("So tien phai tra: "+tien);
        }
    }
}