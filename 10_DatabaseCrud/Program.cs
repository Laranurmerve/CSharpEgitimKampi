using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            #region Kategory Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Katagori Adı : ");
            //string catagoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-ALL7VVV\\SQLEXPRESS ; Initial catalog = EğitimKampiDb ; Integrated Security = True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (catagoryName) values (@p1) ", connection );
            //command.Parameters.AddWithValue("@p1", catagoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi !!!!!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection= new SqlConnection("Data source = DESKTOP-ALL7VVV\\SQLEXPRESS ; Initial catalog =EğitimKampiDb ; Integrated Security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (productName , productPrice , productStatus) values (@p1,@p2,@p3) " , connection );
            //command.Parameters.AddWithValue("@p1", productName);    
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Başarıyla Eklendi !!!!!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-ALL7VVV\\SQLEXPRESS ; Initial Catalog = EğitimKampiDb ; Integrated Security = True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //       Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id : ");
            //int productId = Convert.ToInt32(Console.ReadLine());  


            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-ALL7VVV\\SQLEXPRESS ; Initial Catalog = EğitimKampiDb ; Integrated Security = True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct where productId = @p1", connection);
            //command.Parameters.AddWithValue("@p1", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Silindi !!!!!");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id : ");

            //int productId = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = DESKTOP-ALL7VVV\\SQLEXPRESS ; Initial Catalog = EğitimKampiDb ; Integrated Security = True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct set productName = @p1 , productPrice = @p2 where productId = @p3", connection);

            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Güncellendi !!!!!");

            #endregion

            Console.Read();


        }
    }
}
