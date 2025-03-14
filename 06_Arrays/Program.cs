using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri 

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı];    
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[7] = 50;
            //numbers[8] = 60;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Atina", "Roma"  ,"Ankara" , "Bursa"};

            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Kırmızı", "Sarı", "Beyaz", "Mavi", "Yeşil " , "Turuncu ", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{ 
            //     Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0  )
            //    Console.WriteLine(numbers[i]);
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] numbers = { 58, 29, 48, 759, 462, 100, 1 };

            //int maxNumbers = numbers[0];

            //for ( int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumbers)
            //    {
            //        maxNumbers = numbers[i];
            //    }
            //}

            //string[] persons = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Zeynep" };

            //Console.WriteLine(persons.Length);


            // KÜÇÜKTEN BÜYÜĞE SIRALAMA

            //int[] numbers = { 58, 29, 48, 759, 462, 100, 1 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 

            // TERSTEN SIRALAMA

            //int[] numbers = { 58, 29, 48, 759, 462, 100, 1 };

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}





            #endregion

            #region Dizi Metotları


            // HANGİ İNDEKSTE OLDUĞUNU BULMA
            //string[] customer = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Zeynep" };
            //int index = Array.IndexOf(customer, "Zeynep");

            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine("Dizinin En Büyük Elemanı : "  +  numbers.Max() + " Dizinin En Küçük Elemanı : " + numbers.Min() );


            #endregion

            #region Kullanıcıdan Dizi Elemanları Alma
            //string[] cities = new string[5];

            //for(int i = 0; i  < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1 }.Şehir Adı Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}


            //Console.Clear();


            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //Console.WriteLine("-----------------------------");

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Dizinin Toplamı : " + sum);

            //int[] numbers = { 21, 42, 33, 54 , 55, 66, 897, 748, 39 ,  220};
             
            //Console.WriteLine("Çift Sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0 )

            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("Tek Sayılar : ");

            //for (int k = 0; k < numbers.Length; k++)

            //{
            //    if (numbers[k] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[k]);
            //    }
            //}

            #endregion


            Console.Read();

        }
    }
}
