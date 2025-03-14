using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar 

            //void CustomerList()
            //{
            //    Console.WriteLine("Nursena");
            //    Console.WriteLine("Büşra");
            //    Console.WriteLine("Merve");
            //    Console.WriteLine("Sena");
            //}

            //CustomerList();

            //void sum()
            //{
            //    int x = 5;
            //    int y = 10;
            //    int z = x + y;
            //    Console.WriteLine("Toplam: " + z);
            //}

            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar 

            //void CustomerName(string name)
            //{
            //    Console.WriteLine("Müşteri Adı: " + name);
            //}

            //CustomerName("Nursena");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " +  surname);

            //}

            //CustomerCard("Nursena", "Kaya");
            //CustomerCard("Büşra", "Ata");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar 

            //void Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //Sum(5, 10);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    //geriye değer döndüren metotlarda döndürme işini return yapar.
            //    return "Nursena";
            //}

            //customerName();

            //string StudentCard()
            //{
            //    string name = "Nursena";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard (string countryName , string capital , string flogClore )
            //{
            //    string cardInfo = "Ülke : " + countryName + " - Başkenti :  " + capital + " - Bayrak Rengi : " + flogClore;
            //    return cardInfo;   
            //}

            //string  x , y, z;

            //Console.Write(" Lütfen ülkeyi giriniz :");
            //x = Console.ReadLine();

            //Console.Write(" Lütfen başkenti giriniz :");
            //y = Console.ReadLine();

            //Console.Write(" Lütfen bayrağın rengini giriniz :");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));



            #endregion

            #region  Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(15, 10));
            //Console.WriteLine(Sum(35, 10));
            //Console.WriteLine(Sum(25, 10));
            //Console.WriteLine(Sum(45, 10));
            //Console.WriteLine(Sum(55, 10));



            #endregion

            #region Örnek Uygulama

            string ExamResult(string student , int exam1 , int exam2 , int exam3 )
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci " + result + " ortalama ile geçti";
                }
                else
                {
                    return student + " isimli öğrenci " + result + " ortalama ile kaldı";
                }
            }

            Console.WriteLine(ExamResult("Nursena", 50, 60, 70));
            Console.WriteLine(ExamResult("Büşra", 40, 60, 30));

            #endregion



            Console.Read();
        }
    }
}
