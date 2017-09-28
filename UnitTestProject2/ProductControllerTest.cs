using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAPP;
using Moq;
using FluentAssertions;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void MethodToTestUsingMock()
        {
            var listofProducts = new List<Product>();
            listofProducts.Add(
               new Product { code = "xxx", name = "Potato", price = 15, quantity = 300 }
               );

            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetProducts()).Returns(listofProducts);
            var prodController = new ProductController(mockRepository.Object);
            prodController.TestThis();
            prodController.Should().NotBeNull();
        }
        [TestMethod]
        public void MethodToTestUsingFake()
        {
            //var listofProducts = new List<Product>();
            //listofProducts.Add(
            //   new Product { code = "xxx", name = "Potato", price = 15, quantity = 300 }
            //   );

            FakeRepository fake = new FakeRepository();
          /*  Mock<IRepository> mockRepository = new Mock<IRepository>();*/
            //mockRepository.Setup(x => x.GetProducts()).Returns(listofProducts);
            var prodController = new ProductController(fake);
            prodController.TestThis();
            prodController.Should().NotBeNull();
        }
        [TestMethod]
        public void MethodToTestUsingDummy()
        {
            var listofProducts = new List<Product>();
            listofProducts.Add(
               new Product { code = "xxx", name = "Potato", price = 15, quantity = 300 }
               );

            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetProducts()).Returns(listofProducts);
            var prodController = new DummyProductController(mockRepository.Object);
            prodController.TestThis();
            prodController.Should().NotBeNull();
        }

        [TestMethod]
        public void MethodToTestUsingSTUB()
        {
            var listofProducts = new List<Product>();
            listofProducts.Add(
               new Product { code = ProductStub.STUB_CODE, name = ProductStub.STUB_NAME, price = ProductStub.STUB_PRICE, quantity = ProductStub.STUB_QUANTITY }
               );

            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetProducts()).Returns(listofProducts);
            var prodController = new ProductController(mockRepository.Object);
            prodController.TestThis();
            prodController.Should().NotBeNull();
        }
        [TestMethod]
        public void MethodToTestUsingSPY()
        {
            var listofProducts = new List<Product>();
            listofProducts.Add(
               new Product { code = "xxx", name = "Potato", price = 15, quantity = 300 }
               );

            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetProducts()).Returns(listofProducts);
            var prodController = new ProductControllerSpy(mockRepository.Object);
            prodController.TestThis();
            Assert.AreEqual(prodController.SpyData, "Potato\n");
            prodController.Should().NotBeNull();
        }
    }
}
