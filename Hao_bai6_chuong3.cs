using System;
class Program{
    static void Main(string[] args){
        int tam;
        int so_hoan_doi = 0;
        int n = int.Parse(Console.ReadLine());
        while(n > 0){
            tam = n % 10;
            so_hoan_doi = so_hoan_doi * 10 + tam;
            n = n / 10;
        }
        Console.WriteLine(so_hoan_doi);
    }
}