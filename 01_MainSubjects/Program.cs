using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutlar
            //Console.WriteLine("Hello World");
            //Console.Write("selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler
            // string

            //string name;
            //name = "Lara";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Lara";
            //customerSurname = "NAMLI";
            //customerPhone = "+90 554 196 14 62";
            //customerEmail = "mervelara1453@cmail.com";
            //district = "Bağcılar";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı **** ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname  );
            //Console.WriteLine("İletişim :" + customerPhone );
            //Console.WriteLine( "Email : " +  customerEmail );
            //Console.WriteLine("Adres :" + district + "/" + city );
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //customerName = "Enes ";
            //customerSurname = "KIZILKAYA";
            //customerPhone = " +90 543 165 41 88";
            //customerEmail = " Bilinmiyor ";
            //district = "Bağcılar ";
            //city = "İstanbul";
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email : " + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();



            //Console.WriteLine("**** Rezervasyon Kartı ****");
            #endregion

            #region int Değişkeni

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadPrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine("");
            Console.WriteLine("-----Hamburger : "+ hamburgerPrice + "TL ");
            Console.WriteLine("-----Pizza : " + pizzaPrice + "TL");
            Console.WriteLine("-----Cola : " + cokePrice + "TL ");
            Console.WriteLine("-----Limonata : " + lemonadPrice + "TL ");
            Console.WriteLine("-----Kızartma : " + friesPrice + "TL ");
            Console.WriteLine("-----Su : " + waterPrice + "TL ");
            Console.WriteLine("");
            Console.WriteLine("**** Restorant Menü Fiyatı ****");

           
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadCount;

            int totelhamburgerPrice;
            int totelcokePrice;
            int totelWaterPrice;
            int totelfriesPrice;
            int totelpizzaPrice;
            int totellemonadPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadCount = 0;


            totelhamburgerPrice = hamburgerCount * hamburgerPrice;
            totelcokePrice = cokeCount * cokePrice;
            totelWaterPrice = waterCount * waterPrice;
            totelfriesPrice = friesCount *  friesPrice;
            totelpizzaPrice = pizzaCount  * pizzaPrice;
            totellemonadPrice = lemonadCount * lemonadPrice;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı :" + totelhamburgerPrice + "TL" );
            Console.WriteLine("Pizza Tutarı : " + totelpizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı : " + totelfriesPrice + "TL ");
            Console.WriteLine("Kola Tutarı : " + totelcokePrice + "TL ");
            Console.WriteLine("Limonata Tutarı : " + totellemonadPrice + "TL ");
            Console.WriteLine("Su Tutarı :" + totelWaterPrice + "TL ");

            Console.WriteLine();
             int totelPrice = totelhamburgerPrice + totelcokePrice + totelWaterPrice + totelfriesPrice + totelpizzaPrice + totellemonadPrice ;

            Console.WriteLine("TOPLAM TUTAR : " + totelPrice + " TL");


            #endregion

            #region


            #endregion
            Console.Read();
        }
    }
}




// Yazdırma Komutları 