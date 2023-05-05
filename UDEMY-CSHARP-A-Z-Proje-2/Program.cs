using System;
namespace Deneme;
//Alışveriş indirim sistemi uyguluması
//sabit fiyat, aralıklı inidirim
//0-20- ==> %20
//21-40 ==> %40
//41++ ==> %50

    class Program
    {
     static void Main(string[] args)
     {
        int kitapAdet;
        double toplam;
        Console.WriteLine("Lütfen kitap Adedini giriniz.....");
        kitapAdet = Convert.ToInt32(Console.ReadLine());
        if(kitapAdet >=0 && kitapAdet <=20)
        {   
            toplam=(kitapAdet*8)-(kitapAdet*8 * 0.20); 
            Console.WriteLine(toplam + "TL");
        }
        if(kitapAdet >=21 && kitapAdet <=40)
        {
             toplam=(kitapAdet*8)-(kitapAdet*8 * 0.40);
             Console.WriteLine(toplam + "TL");
        }
        if(kitapAdet >=41){
            toplam=(kitapAdet*8)-(kitapAdet*8 * 0.40);
            Console.WriteLine(toplam + "TL");

        }
     }
    }
