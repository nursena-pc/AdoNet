using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class Product
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public decimal Fiyat { get; set; }
        public int KalanAdet { get; set; }
    }
}
