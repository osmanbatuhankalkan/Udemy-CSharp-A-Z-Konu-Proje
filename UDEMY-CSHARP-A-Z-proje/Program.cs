using System;
namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {   
            int urunNumarası,baslamaDegeri;
            Console.WriteLine("Sistemi Başlatmak İçin Lütfen 0'ı Tuşlayınız !");
            baslamaDegeri = Convert.ToInt32(Console.ReadLine());
            if(baslamaDegeri==0){
                Console.WriteLine("Hoşgeldiniz, İstediğiniz ürüne göre şu rakamları tuşlayabilirsiniz:(1:Mısır),(2:Su),(3:Çay),(4:Bilet).");

                urunNumarası = Convert.ToInt32(Console.ReadLine());
            if(urunNumarası==1){
                Console.WriteLine("Mısır: 15 TL");
                Console.WriteLine("İşlem Başarılı, Bizi Tercih Ettiğiniz İçin Teşekkür Eder, Yine Bekleriz ...");          
            }

            if(urunNumarası==2){
                Console.WriteLine("Su: 1 TL");
                Console.WriteLine("İşlem Başarılı, Bizi Tercih Ettiğiniz İçin Teşekkür Eder, Yine Bekleriz ...");
            }

            if(urunNumarası==3){
                Console.WriteLine("Çay: 10 TL");
                Console.WriteLine("İşlem Başarılı, Bizi Tercih Ettiğiniz İçin Teşekkür Eder, Yine Bekleriz ...");
            }
            
            if(urunNumarası==4){
                Console.WriteLine("Bilet: 20 TL");
                Console.WriteLine("İşlem Başarılı, Bizi Tercih Ettiğiniz İçin Teşekkür Eder, Yine Bekleriz ...");
            }

        }else
            Console.WriteLine("Hatalı Tuşlama Yaptınız Tekrar Deneyiniz....");
            
        }
    }
}

