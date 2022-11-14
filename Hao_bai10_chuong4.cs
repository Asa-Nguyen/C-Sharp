using System;
class Program{
    static void Main(string[] args){
        //ax^2 + bx + c = 0
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        if(a==0){
            if(b==0){
                if(c==0){
                    Console.WriteLine("Phuong trinh co vo so nghiem ");
                }else{
                    Console.WriteLine("Phuong trinh vo nghiem ");
                }
            }else{
                Console.WriteLine("Phuong trinh co nghiem: "+(float)-c/b);
            }
        }else{
            float d = b*b - 4*a*c;
            if(d<0){
                Console.WriteLine("Phuong trinh vo nghiem ");
            }
            if(d==0){
                Console.WriteLine("Phuong trinh co nghiem kep x = "+(float)-b/(2*a));
            }else{
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1 = " + (float) (-b+Math.Sqrt(d)) / (2*a) + "\tx2 = " + (float) (-b-Math.Sqrt(d)) / (2*a));
            }
        }
    }
}