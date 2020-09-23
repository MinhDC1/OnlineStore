using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using OnlineStore.Controllers;
using OnlineStore.Models;
using Xunit;

namespace OnlineStore.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
                { new Product { ProductID = 1, Name = "P1"},
                  new Product { ProductID = 2, Name = "P2"}
                }).AsQueryable<Product>());

            HomeController controller = new HomeController(mock.Object);

            // Act
            IEnumerable<Product> result =
                (controller.Index() as ViewResult).ViewData.Model
                as IEnumerable<Product>;

            // Assert
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P1", prodArray[0].Name);
            Assert.Equal("P2", prodArray[1].Name);
        }


    }
}
