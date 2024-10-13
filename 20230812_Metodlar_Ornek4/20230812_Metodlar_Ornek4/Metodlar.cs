using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar_Ornek4
{
    internal class Metodlar
    {
        public void Toplama(int sayi1,int sayi2)
        {
            int toplam=sayi1+ sayi2;
            Console.WriteLine("Sayıların Toplamı = "+toplam);
        }
        public void Cikarma(int sayi1,int sayi2)
        {
            int sonuc=sayi1- sayi2;
            Console.WriteLine("Sayıların Farkı = "+sonuc);
        }

        
    }
}
