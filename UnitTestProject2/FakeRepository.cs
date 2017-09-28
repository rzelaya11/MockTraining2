using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAPP;

namespace UnitTestProject2
{
    public class FakeRepository:IRepository
    {
        public List<Product> GetProducts()
        {
            var listProd = new List<Product>();
            listProd.Add(
                new Product { code = "fae", name = "Potato", price = 15, quantity = 300 }
                );
            return listProd;

        }
    }
}
