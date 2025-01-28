using System;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfe şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ANKARA" && country == "TÜRKİYE" )
            //{

            //    Console.WriteLine("Veriler doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Veriler yanlış");
            //}

            //int average;
            //Console.Write("Bir sayı giriniz : ");
            //average = Convert.ToInt32(Console.ReadLine());

            //if (average == 5)
            //{ 
            //   Console.WriteLine("Doğru tercih");
            //}
            //else
            //{
            //        Console.WriteLine("Yanlış tercih");
            //}

            //double exam1, exam2, exam3, average;

            //Console.Write("1.Sınavdan aldığınız puanı giriniz : ");
            //exam1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("2.Sınavdan aldığınız puanı giriniz : ");
            //exam2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("3.Sınavdan aldığınız puanı giriniz : ");
            //exam3 = Convert.ToDouble(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız : " + average);




            //if (0 >= average || average <= 50)
            //{ 
            //   Console.WriteLine("Vasat");
            //}
            //else if (51 >= average || average <= 70)
            //{
            //Console.WriteLine("Orta");
            //}
            //else if (71 >= average || average <= 84)
            //{
            //    Console.WriteLine("İyi");
            //}
            //else if (85 <= average )
            //{
            //    Console.WriteLine("Çok İyi");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Puan Girişi !!!!! ");
            //}

            //string city;
            //Console.Write("Bir şehir adı giriniz : ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehirler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şehirler yanlış");
            //}


            //Console.Write("Bir kullanıcı adı giriniz : ");

            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez !!!!!!");

            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz ");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;

            //int result = number % 4;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.Write("Lütfen bir sayı giriniz : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{

            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //Char team;
            //Console.Write("Bir takım sembolünü giriniz : ");
            //team = Convert.ToChar(Console.ReadLine());


            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış sembol girişi");
            //}



            #endregion

            #region Örnek Uygulama Projesi 

            //Console.WriteLine("****** C#Eğitim Kampı Restoran Menüsü ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Ana Yemekler ");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi : ");
            //menuItem = Console.ReadLine();

            //if (menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk ");
            //    Console.WriteLine("2-Kızartma Tabağı ");
            //    Console.WriteLine("3-Fırında Somon ");
            //    Console.WriteLine("4-Patlıcan Musakka ");
            //    Console.WriteLine("5-Fasulye Pilav ");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");

            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası ");
            //    Console.WriteLine("2-Ezogelin Çorbası ");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita ");
            //    Console.WriteLine("2-Akdeniz Pizzası ");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola ");
            //    Console.WriteLine("2-Ayran ");
            //    Console.WriteLine("3-Su ");
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe ");
            //    Console.WriteLine("2-Kazandibi ");
            //    Console.WriteLine("3-Sütlaç ");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış seçim yaptınız");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız : ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1 : Console.Write("Ocak"); 
            //        break;
            //    case 2 : Console.Write("Şubat"); 
            //        break;
            //    case 3 : Console.Write("Mart");
            //        break;
            //    case 4 : Console.Write("Nisan");
            //        break;
            //    case 5 : Console.Write("Mayıs");
            //        break;
            //    case 6 : Console.Write("Haziran");
            //        break;
            //    case 7 : Console.Write("Temmuz"); 
            //        break;
            //    case 8 : Console.Write("Ağustos"); 
            //        break;
            //    case 9 : Console.Write("Eylül"); 
            //        break;
            //    case 10 : Console.Write("Ekim"); 
            //        break;
            //    case 11 : Console.Write("Kasım"); 
            //        break;
            //    case 12 : Console.Write("Aralık");
            //        break;
            //    default: Console.Write("Yanlış ay girişi yaptınız"); 
            //        break;


            //}




            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. Sayıyı giriniz : ");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz : ");
            //number2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İşlemi giriniz : ");
            //symbol = Convert.ToChar(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama işlemi sonucu : " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma işlemi sonucu : " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma işlemi sonucu : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme işlemi sonucu : " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış işlem girişi yaptınız");
            //        break;

            //}



            #endregion




            Console.ReadLine();

        }
    }
}
