using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_ile_hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Hesap Makinesine Hoş Geldiniz");
            Console.WriteLine("Devam etmek için lütfen herhangi bir tuşa basınız");
            Console.ReadLine();

            Console.WriteLine("lütfen ilk sayıyı yazınız");
            int sayi1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Toplama için 1, çıkaram için 2 ,Bölme için 3, Ortalama için 4, çarpma içinse 5 şe basınız");
            int işlem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkince sayıyı giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());

            double toplama = sayi1 + sayi2;
            int çıkarma = sayi1 - sayi2;
            double bölme = sayi1 / sayi2;
            double ortalama = (sayi1 + sayi2) / 2;
            double çarpma = sayi1 * sayi2;

            switch (işlem)
            {
                case 1: Console.WriteLine(toplama); break;
                case 2: Console.WriteLine(çıkarma); break;
                case 3: Console.WriteLine(bölme); break;
                case 4: Console.WriteLine(ortalama); break;
                case 5: Console.WriteLine(çarpma); break;

            }
            
            Console.ReadLine() ;



        }
    }
}
