using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint7.Project.V5.Lib;
using static Tyuiu.ReshetovaAA.Sprint7.Project.V5.Lib.DataService;

namespace Tyuiu.ReshetovaAA.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        // проверяю, что AddProduct добавляет запись
        [TestMethod]
        public void AddProduct_AddOneElement_CountIsOne()
        {
            DataService ds = new DataService();

            Product p = new Product();
            p.Code = "001";
            p.Name = "Тестовый товар";
            p.Quantity = 10;
            p.Price = 100;
            p.Note = "Тест";

            ds.AddProduct(p);

            Assert.AreEqual(1, ds.Products.Count);
        }

        // проверка поиска по названию
        [TestMethod]
        public void SearchByName_FindCorrectItem()
        {
            DataService ds = new DataService();

            Product p1 = new Product { Code = "1", Name = "Сахар", Quantity = 5, Price = 50, Note = "" };
            Product p2 = new Product { Code = "2", Name = "Соль", Quantity = 3, Price = 20, Note = "" };

            ds.AddProduct(p1);
            ds.AddProduct(p2);

            var result = ds.SearchByName("сах");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Сахар", result[0].Name);
        }
    }
}
