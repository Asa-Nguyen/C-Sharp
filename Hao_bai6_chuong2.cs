using System;
class Program{
    static void Main(string[] args){
        double dola = double.Parse(Console.ReadLine());
        double anh = dola*0.8144;
        double nhat = dola*105.407;
        double vnd = dola *23160;
        Console.WriteLine(anh);
        Console.WriteLine(nhat);
        Console.WriteLine(vnd);
    }    
}