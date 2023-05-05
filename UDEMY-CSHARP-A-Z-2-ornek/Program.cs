 using System;
namespace Deneme
{
    class program
    {
        static void Main(string[] args)
        {   string ad,soyad;
            int s1,s2,proje,toplam;
            double ortalama;

            Console.WriteLine("Lütfen Kullanıcının Adınızı Giriniz !");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine(ad);

            Console.WriteLine("Lütfen Kullanıcının Soyadınızı Giriniz !");
            soyad=Convert.ToString(Console.ReadLine());
            Console.WriteLine(soyad);

            Console.WriteLine("Lütfen Kullanıcının sırasıyla not1,not2,proje notlarını giriniz !");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            proje = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ortalama Degeriniz !");
            toplam = (s1 + s2 + proje)/3;
            Console.WriteLine(toplam);
        
        }
    }
}