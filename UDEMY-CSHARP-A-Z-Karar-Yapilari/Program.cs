using System;
namespace deneme;

//Genel-Operatörler
// (=) --> (atama)
// (+,-,*,/) --> (aritmetik işlemler)
// (==) --> (Sorgulama)
// (>=) --> (Büyük Eşit)
// (<=) --> (Küçük Eşit)
// (!=) --> (Eşit Değilse)
// (&&) --> (Ve Anlamına Gelir)
// (//) --> (Veya Anlamına Gelir)
// (%) --> (Mod Anlamına Gelir)
//İf - Else
//Switch - Case

class Program
{
    static void Main(string[] args)
    {   /******************************************************************/
        /**************************-İF-ELSE-*******************************/
        /******************************************************************/

        Console.WriteLine("Tek-Çift Programı için sayı giriniz....");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if(sayi %2 ==0)
        {
            Console.WriteLine("çift",sayi);
        }
        else {
            Console.WriteLine("Tek");
        }

        /******************************************************************/
        /******************************************************************/

        Console.WriteLine("Ondan Büyük ve Çift Programı için sayı giriniz....");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        if(sayi2 %2 ==0 && sayi2 >= 10)
        {
            Console.WriteLine("Ondan Büyük ve Çift",sayi2);
        }
        else {
            Console.WriteLine("Ondan Büyük Değil ve Çift Değil");
        }

        /******************************************************************/
        /******************************************************************/

         Console.WriteLine("Ondan Büyük veya Çift Programı için sayı giriniz....");
        int sayi3 = Convert.ToInt32(Console.ReadLine());
        if(sayi3 %2 ==0 || sayi3 >= 10)
        {
            Console.WriteLine("Ondan Büyük veya Çift",sayi3);
        }
        else {
            Console.WriteLine("Ondan Büyük Değil veya Çift Değil");
        }

        /******************************************************************/
        /*********************-SWİTCH-CASE-********************************/
        /******************************************************************/
        //Karar yapılarının şartları çok ise tercih edilir,Dallanma çok ise.

        Console.WriteLine("Yılın bir ayı için değer giriniz !!");
        int ay = Convert.ToInt32(Console.ReadLine());
        switch(ay) //switch burada bir anahtar görevi görüyor
        {
            case 1: Console.WriteLine("Ocak"); //istediğimizi yaptırdık
            break;//kapadık
            case 2:  Console.WriteLine("Şubat");
            break;
            case 3:  Console.WriteLine("Mart");
            break;
            case 4:  Console.WriteLine("Nisan");
            break;
            case 5:  Console.WriteLine("Mayıs");
            break;
            case 6:  Console.WriteLine("Haziran");
            break;
            case 7:  Console.WriteLine("Temmuz");
            break;
            case 8:  Console.WriteLine("Ağustos");
            break;
            case 9:  Console.WriteLine("Eylül");
            break;
            case 10:  Console.WriteLine("Ekim");
            break;
            case 11:  Console.WriteLine("Kasım");
            break;
            case 12:  Console.WriteLine("Aralık");
            break;
            default: Console.WriteLine("Hatalı Ay Girdiniz");//istenilen durum harici degerler için kullanılır
            break;

            /******************************************************************/
            /*************************-MEVSİMLER-******************************/
            /******************************************************************/

            Console.WriteLine("Yılın bir mevsimini giriniz !!");
            string mevsim = Console.ReadLine();
            string ilkbahar,Yaz,Sonbahar,Kış;
            switch(mevsim)
            {
                case "ilkbahar":  Console.WriteLine("İlkbahar");
                break;
                case "Yaz": Console.WriteLine("Yaz");
                break;
                case "Sonbahar":  Console.WriteLine("Sonbahar");
                break;
                case "Kış":  Console.WriteLine("Kış");
                break;
                default: Console.WriteLine("Hatalı Mevsim Tuşu Girdiniz");
                break;
            }

        }

    }
}