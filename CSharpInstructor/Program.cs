namespace CSharpInstructor
{



    class Program
    {
        static void Main(string[] args)
        {
            //main metod


           /* Ders2 Degiskenler*/



            //int sayi1 = 123;
            //string yazi1 = "selam";
            //bool dy1 = true;
            //double sayi = 10.2;
            //decimal bune;

            //int sayi2 = 32;

            //int sayi3 = sayi1 + sayi2;

            //Console.WriteLine(sayi3);

            //string ad = "Halid";
            //string soyad = "Gunduz";

            //string adsoyad = ad + soyad;


            //Console.WriteLine(adsoyad);

            //Console.Read();

            /*
            double decimal ayni decimal'in hassasiyeti daha fazla

            degisken adi
            sayi ile baslamaz
            arada bosluk olmamali
            turkce karakter kullanilmaz
            dile ozgu anahtar kelimeler kullanilmaz

            */

            bool secim;
            secim = true;
            secim = false;

            Console.WriteLine(secim);

            //Java Gibi Yukaridan asagiya calisir


            /*Ders3 Diziler*/

            //Liste seklinde degiskenler



            //Diziler icindeki elemanlar index numaralariyla birbirinden ayrilir.
            //Index numaralari 0'dan baslar Java gibi

            int[] sayilar = { 10, 20, 30, 45, 56, 63 };
            string[] isimler = { "Halid", "mehmet", "Sungur", "Kirito" };
            

            Console.WriteLine("1. Eleman: {0}",isimler[0]);
            Console.WriteLine("2. Eleman: {0}",isimler[1]);
            Console.WriteLine("3. Eleman: {0}",isimler[2]);
            Console.WriteLine("4. Eleman: {0}",isimler[3]);

            Console.WriteLine("1. Eleman: {0}"+ sayilar[0]);
            Console.WriteLine("2. Eleman: {0}"+ sayilar[1]);
            Console.WriteLine("3. Eleman: "+ sayilar[2]);
            Console.WriteLine("4. Eleman: "+ sayilar[3]);
            sayilar[3] = 85;

            //Ders4 Kontrol Ifadeleri
            //If-else & Switch-Case











            Console.Read();
        }



    }

}