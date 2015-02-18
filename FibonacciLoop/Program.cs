using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace FibonacciLoop
{
    class Program
    {
        public static double Fibonacci(double n) //Fibonacci Sayısını Bulan Fonksiyon
        {
            double a = 0;
            double b = 1;
            // N. fibonacci sayisi
            for (double i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch(); //Programın çalışma süresini öğrenebilmek için Stopwatch fonksiyonundan yararlanıldı
            
           
            Console.Write("Kacinci fibonacci sayisini ogrenmek istersiniz? :"); //Kaçıncı fibonacci dizisi isteniyorsa o isteniyor.
            double x = double.Parse(Console.ReadLine()); //Fibonacci sayısının girilmesi istendi.
            watch.Start(); //Süre başlatıldı

            Console.WriteLine();

            Console.Write("{0}. fibonacci sayisi : ", x);
            Console.WriteLine(Fibonacci(x)); //Sonuç ekrana basılıyor.

            watch.Stop(); //Süre durduruldu

            
            TimeSpan timer = watch.Elapsed; //Süre değerlerine erişmek için timer değişkeni oluşturuldu.
            
            Console.Write("Programin calisma süresi: ");

            string sonuc = String.Format("{0}:{1}:{2}.{3}", timer.Hours, timer.Minutes, timer.Seconds, timer.TotalMilliseconds * 1000000);//Süre saat,dakika,saniye ve milisaniye olarak gösterildi

            Console.Write(sonuc); //Ekrana sonuç yazdırıldı

            Console.WriteLine(); //Bu tip kod satırları konsol çıktısını daha düzgün bir biçimde görmek amacıyla kullanılmıştır.
            Console.Write("Cikmak için ENTER'a basiniz "); // Çıkmak için enter a basılması gerekli.
            Console.WriteLine("");
            Console.ReadLine(); //Ekranda sonucu görebilmemiz için eklendi.Enter a basılınca uygulama kapanır.
        }

    }
}