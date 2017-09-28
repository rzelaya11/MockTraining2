using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAPP;
namespace UnitTestProject2
{
    public class DummyProductController:ProductController
    {
        IRepository repository;

        public DummyProductController(IRepository repo):base(repo)
        {
            repository = repo;
        }


        public void TestThis()
        {
           
        }

    }
}
