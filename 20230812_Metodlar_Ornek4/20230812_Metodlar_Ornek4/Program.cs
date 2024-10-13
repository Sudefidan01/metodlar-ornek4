using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar_Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 adet sayı isteyelim
            //1-Toplama , 2-Çıkarma işlemi şeklinde menü hazırlayalım
            //Kullanıcının seçmiş olduğu değere göre toplama veya çıkarma işlemi yaptıralım
            Console.Write("Birinci Sayıyı Giriniz :");
            int sayi1=int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz : ");
            int sayi2=int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("------------");
            Console.Write("İşlem Türünü Seçin :");
            int secim=int.Parse(Console.ReadLine());

            Metodlar metod = new Metodlar();
            switch (secim)
            {
                case 1:
                    metod.Toplama(sayi1,sayi2);
                    break;
                case 2:
                    metod.Cikarma(sayi1,sayi2);
                    break;
            }

            Console.ReadKey();
        }
    }
}
