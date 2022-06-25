using Entities.Concreate;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concreate
{
    public class ProductManager : IProductService
    {
        public Product ByID(int id)
        {
            return new Product
            {
                Id = 1,
                ProductName = "Kolye",
                Stock = 12,
                Description = "Taşlı Kolye"
            };
        }

        public List<Product> GetAll()
        {
            Random random = new Random();
            return new List<Product>() {
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
                new Product{Id=random.Next(5),ProductName="Kolye",Stock=random.Next(5),Description="Kolye"},
            };
        }
    }
}
