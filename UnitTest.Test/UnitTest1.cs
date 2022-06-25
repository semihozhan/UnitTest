using Entities.Concreate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Web.Http.Results;
using UnitTest.Controllers;

namespace UnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        ProductController controller;
        Mock<IProductService> mock;
        Random random = new Random();

        [TestInitialize]
        public void Initialize()
        {
            mock = new Mock<IProductService>();
            controller = new ProductController(mock.Object);
        }


        [TestMethod]
        public void GetAll_WhenIsSuccess()
        {
            
            var excepted = new List<Product>() {
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"}
            };

            

            mock.Setup(p => p.GetAll()).Returns(excepted);
            var response = controller.GetAll();
            Assert.IsInstanceOfType(response, typeof(List<Product>));

            //var responseData = (response as OkNegotiatedContentResult<List<Product>>).Content;

           // Assert.AreEqual(excepted.Count, responseData.Count);

        }

        [TestMethod]
        public void ById_ReturnsProduct_WheneverytinkIsOk()
        {
            var expected = new Product {Id = random.Next(5), ProductName = "Kolye", Stock = random.Next(5), Description = "Kolye "};

            mock.Setup(x => x.ByID(It.IsAny<int>())).Returns(expected);

            var response = controller.ById(It.IsAny<int>());

            Assert.IsInstanceOfType(response, typeof(Product));


        }

        [DataRow(-1)]
        [TestMethod]
        public void ById_ThrowException_WhenInvalidProductID(int id)
        {
            Assert.ThrowsException<Exception>(()=>controller.ById(id));
        }


    }
}