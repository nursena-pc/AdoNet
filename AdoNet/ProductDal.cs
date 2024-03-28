using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class ProductDal
    {
        SqlConnection _connection =new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=trendyol; integrated security=true");
        private void BaglantiKontrol()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product> Listele()
        {
            BaglantiKontrol();
            SqlCommand communication = new SqlCommand("Select * from Trendyol", _connection);
            SqlDataReader reader = communication.ExecuteReader();
            
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Isim = reader["Isim"].ToString(),
                    Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                    KalanAdet = Convert.ToInt32(reader["KalanAdet"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }
        public void Ekleme(Product product)
        {
            BaglantiKontrol();
            SqlCommand communication = new SqlCommand("Insert into Trendyol values(@Isim,@Fiyat,@KalanAdet)", _connection);
            communication.Parameters.AddWithValue("@Isim", product.Isim);
            communication.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            communication.Parameters.AddWithValue("@KalanAdet", product.KalanAdet);
            communication.ExecuteNonQuery();
            _connection.Close();

        }
        public void Güncelleme(Product product)
        {
            BaglantiKontrol();
            SqlCommand communication = new SqlCommand("Update Trendyol set Isim=@Isim, Fiyat=@Fiyat,KalanAdet=@KalanAdet where Id=@Id", _connection);
            communication.Parameters.AddWithValue("@Isim",product.Isim);
            communication.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            communication.Parameters.AddWithValue("@KalanAdet", product.KalanAdet);
            communication.Parameters.AddWithValue("@Id", product.Id);
            communication.ExecuteNonQuery();
            _connection.Close();
        }
        public void Sil(int id)
        {
            BaglantiKontrol();
            SqlCommand communication = new SqlCommand("Delete from Trendyol where Id=@Id", _connection);
            communication.Parameters.AddWithValue("@Id", id);
            communication.ExecuteNonQuery();
            _connection.Close();
        }

    }
    
}
