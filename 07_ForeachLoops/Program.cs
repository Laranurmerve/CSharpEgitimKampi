using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Foreach Döngüsü

            //Foreach (1 ; 2 ; 3 ; 4)
            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Dizi , koleksiyon ,liste

            //string[] cities = { "Ankara", "İstanbul", "İzmir" };


            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 42, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 42, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;


            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine( total);

            //List<int> numbers = new List<int>()
            //    {
            //    42, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394
            //};
            //foreach (int number in numbers)
            //{


            //        Console.WriteLine(number);

            //}

            //string word = "Merhaba";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}





            #endregion

            #region Örnek Sınav Uygulaması


            Console.WriteLine("************ C# Eğitim Kampı Sınav Uygulaması **********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //sınıftaki öğrenci sayısını kullanıcıdan aldık
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");


            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {

                Console.Write($"{i + 1} . öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                //her öğrencinin 3 sınav notu girişi

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}  isimli öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    totalExamResult += value; 

                }
                studentExamAvg[i] = totalExamResult / 3;
                Console.WriteLine();


            }


            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin sınav not ortalaması : {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine("Öğrenci sınıfı geçti");
                }
                else
                {
                    Console.WriteLine("Öğrenci sınıfta kaldı");
                }
                Console.WriteLine("------------------------------");

            }


            #endregion

            Console.Read();
        }
    }
}
