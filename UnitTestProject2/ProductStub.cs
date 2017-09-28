using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAPP;

namespace UnitTestProject2
{
    public class ProductStub:Product
    {
        public static string STUB_NAME = "Potato";
        public static string STUB_CODE = "Potato";
        public static double STUB_QUANTITY = 300;
        public static double STUB_PRICE = 12.5;

        ProductStub()
        {
            this.code=STUB_CODE;
            this.name = STUB_NAME;
            this.price = STUB_PRICE;
            this.quantity = STUB_QUANTITY;
        }

    }
}
