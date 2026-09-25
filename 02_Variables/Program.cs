using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler 
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.Read();

            //Console.WriteLine("***** FİYAT LİSTESİ *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85 ;
            //orangePrice = 20.85 ;
            //strawberryPrice = 45;
            //potatoPrice = 9.74 ;
            //tomatoPrice = 6.88 ;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL ");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice* strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün : Elma - " + " Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + "- Toplam Tutar : " +  appleTotalPrice + " TL ");

            //Console.WriteLine("Alınan Ürün : Portakal - " + " Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + "- Toplam Tutar : " + orangeTotalPrice + " TL ");

            //Console.WriteLine("Alınan Ürün : Çilek - " + " Birim Fiyat : " + strawberryPrice + " - Gramaj : " + appleGram + "- Toplam Tutar : " + strawberryTotalPrice + " TL ");

            //Console.WriteLine("Alınan Ürün : Patates - " + " Birim Fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + "- Toplam Tutar : " + potatoTotalPrice + " TL ");

            //Console.WriteLine("Alınan Ürün : Domate - " + " Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + "- Toplam Tutar : " + tomatoTotalPrice + " TL ");
            //Console.WriteLine();
            //Console.WriteLine();


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice ;

            //Console.WriteLine("----- Alışveriş Toplam Tutar : " + shoppingTotalPrice + " TL -----");


            #endregion

            #region Char Değişkenler 

            //char symbol;
            //symbol = 'a';

            #endregion

            #region Klavyede Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistric, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolsu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistric = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------");

            //Console.WriteLine("Yolcu TC Kimlik No : " + passengerIdentityNumber + " / Yolcu Ad Soyad : " + passengerName + " " + passengerSurname + " " + passengerDistric + " / " + passengerCity + " " + passengerAge);







            #endregion

            #region Klavyeden Tam sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write(" Lütfen kaç adet ayakkabı aldığınızı giriniz : ");
            //shoesCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" Lütfen kaç adet bilgisayar aldığınızı giriniz : ");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" Lütfen kaç adet sandalye aldığınızı giriniz : ");
            //chairCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" Lütfen kaç adet televizyon aldığınızı giriniz : ");
            //tvCount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();


            //int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine("Toplam Tutar : " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz : ");
            //exam1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz : ");
            //exam2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz : ");
            //exam3 = Convert.ToDouble(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("Sınav Ortalamanız : " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gander;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz (E/K) : ");
            //gander = Convert.ToChar(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet : " + gander);



            #endregion


            Console.Read(); 
        }
    }
}
