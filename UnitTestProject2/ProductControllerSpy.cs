using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAPP;

namespace UnitTestProject2
{
    public class ProductControllerSpy:ProductController
    {

        public String SpyData;
        IRepository repository;

        public ProductControllerSpy(IRepository repo)
            :base(repo)
        {
            repository = repo;
        }

        public void TestThis()
        {
            foreach (Product p in repository.GetProducts())
                SpyData = p.name + "\n";

            base.TestThis();
        }

    }
}
