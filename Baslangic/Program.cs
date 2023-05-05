using System;
namespace Deneme
{
    class program
    {
        static void Main(string[] args)
        {
            //*****STRİNG*********//
            //ad,soyad,yaş,meslek,cinsiyet yazdıran bir sistem kurucaz
            string ad,soyad,meslek,cinsiyet;
            int yas;
            ad="Osman Batuhan";
            soyad="Kalkan";
            meslek ="Bilgisayar Mühendisi";
            cinsiyet ="Erkek";
            yas = 22;
            Console.WriteLine(ad,soyad,meslek,cinsiyet,yas);
            Console.WriteLine(meslek,cinsiyet,yas);
            Console.WriteLine(yas);
            //*****İNT*********//
            //Bu İşlemle Bir (İnteger) değeri ---> (Stringe) Çevirmeyi başardık
            int sayi = 24;
            string k = sayi.ToString();
            Console.WriteLine(k);
        //*********************************************************a**************************************************//
            //Hemen bir örnekle bu işi taclandıralım
            //Bu İşlemle Bir (İnteger) değeri ---> (Stringe) Çevirmeyi başardık
            int sayi1,sayi2,sayi3,toplam,sayılar;
            sayi1 = 2;
            sayi2 = 3;
            sayi3 = 94;
            toplam = sayi1 + sayi2 + sayi3;
            string DonusumToplam = toplam.ToString();
            Console.WriteLine(toplam); 
        //*********************************************************a**************************************************//
            //ŞİMDİKİ örnekte dikkat edersek Consoleda alanda "loremipsum" bir değer girmemiz string olarak algılandığı
            //için alan ve cevrede ToString Dönüşümü yapmadık kendisi değeleri otomatik string gördü.
            //********YILDIZLI_BİLGİ********************//
            int kenar,alan,cevre;
            kenar = 10;
            alan = kenar*kenar;
            cevre = kenar*4;
            Console.WriteLine("Alan: " + alan + " " + "Çevre" + " " + cevre);
            //ÖDEV=3 Sınav notu girilen öğrencinin Ortalaması
        //*********************************************************a**************************************************//
            //********ÖDEV********************//
            Console.WriteLine("Bir öğrencimiz var ve 3 adet sınava girdi bunlar sırasıyla girelim ve sonucumuzun ortlamasını görelim");

            int s1,s2,s3,toplamGenel,ort;
            s1 =Convert.ToInt32(Console.ReadLine());
            s2 =Convert.ToInt32(Console.ReadLine());
            s3 =Convert.ToInt32(Console.ReadLine());

            toplamGenel = s1 + s2 + s3;
            //********YILDIZLI_BİLGİ********************//
            //Aman dikkat hem toplama hem bolme ik işi aynı anda yapamıyorsun blmkeyi çıkarma olarak görüyor o yüzden ayrı yapacağız
            ort = toplamGenel/3;
            string DonusumToplam2 = ort.ToString();
            Console.WriteLine(ort);
        //*********************************************************a**************************************************//

            //*****İnteger_Degiskenler_Klavyeden_Veri_Girisi*********//
            //CSHARPTA integerin 3 temel dönüşümü var bunlar sırasıyla söyledir
            //ToInt16 
            //TOInt32 (Dünya Geneli kullanılan)
            //ToInt64
            //bu ifadeleri genelde integer tanımladığımız degelerden string ifade almaya calısınca donusum icin kullanırıs
            //Convert = dönüştür demek
            int sayi66;
            Console.WriteLine("Merhabalar, iyisinizdir inşallah sizden bir sayi gir girmenizi isteyeceğim efenimmm !!");
            sayi66 = Convert.ToInt32(Console.ReadLine());
            string a = sayi66.ToString();
            Console.WriteLine(sayi66);

        //*********************************************************a**************************************************//
        //********Girilen_Sayının_Küpünü_Alan_Program********************//

        int sayıkupu,kupf;
        Console.WriteLine("Selamlar Efenimm Selamlar Şimdi sizden bir sayı yazmanızı isteyeceğim ve yazılan bu sayının küpünü alama işlemi yapacağız");
        sayıkupu = Convert.ToInt32(Console.ReadLine());//CONVERT burada DONUSTURMEK
        kupf = sayıkupu*sayıkupu*sayıkupu;
        string kupSonuc = kupf.ToString();
        Console.WriteLine(kupf);

        //*********************************************************a**************************************************//
        //*********************************************************a**************************************************//
        //********İNTEGER_DEGERLERDE_4_İSLEM********************//
        int deger10,deger11,toplam10,fark,carpım,bolum;
        Console.WriteLine("Dört işlem için 2 deger giriniz.");
        deger10 = Convert.ToInt32(Console.ReadLine());
        deger11 = Convert.ToInt32(Console.ReadLine());

        toplam10 = deger10 + deger11;
        fark = deger10 - deger11;
        bolum = deger10 / deger11;
        carpım = deger10 * deger11;

        Console.WriteLine("Toplam: " +" "+ toplam10+ " " +"Fark: "+ " "+ fark + "Bolum: " + " "+ bolum +" "+ "Carpım: "+" "+ carpım );
        //*********************************************************a**************************************************//
        //*******************************************Double-Degiskenler***********************************************//
        double sayid;
        //*YILDIZLI-BİLGİ
        //Ondalıklı sayılarda tam olan kısımla, tam olmayan kısmı; kod kısmından girersen .(nokta) ile ayırıyorsun
        //klavyeden girilirse ,(virgül) ile ayrılıyor
        sayid = 4.25;
        string DonusumD = sayid.ToString();
        Console.WriteLine(sayid);
        //*********************************************************a**************************************************//
        double s11,s12,s13,ort11;
        s11 =69;
        s12 =68;
        s13 =62;
        ort11 = (s11 + s12 + s13) / 3;
        string DonusumD2 = ort11.ToString("0.00");//toString içine yazdıklarımız virgülden sonra kaç basamak gelsin istiyorsak ona göre oradan ayarlama yaparız
        Console.WriteLine(ort11);
        //*********************************************************a**************************************************//
        //****************************************************CHAR-Degisken*******************************************//
        //char stringe göre daha az yer saklar yerden tasarruf edilir.
        //charın stringden ayrıldığı bir diğer nokta ise tek tırnakla yazılıryor olması 
        //takım tanımlasası yapılabilir
        char takim,sözel1;
        takim = 'g';
        string sonuc = takim.ToString();
        Console.WriteLine(takim);

        Console.WriteLine("Bir sözel ifade giriniz !");
        sözel1 = Convert.ToChar(Console.ReadLine());//NULL Degerler stringde çalışır fakat charda olmaz
        string söz = sözel1.ToString();
        Console.WriteLine(sözel1);
        
        //*********************************************************a**************************************************//        
        

        }
    }
}