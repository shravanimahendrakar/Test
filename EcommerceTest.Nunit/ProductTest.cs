using Ecommerce;
namespace EcommerceTest.Nunit
{
    public class Tests
    {
        private Product product;
        [SetUp]
        public void Setup()
        {
            product = new Product(222, "Apple Phone", 399.9, 40);
        }

        [TestCase(400)]
        [TestCase(500)]
        public void Test_ProductId(int id)
        {
            Assert.That(id, Is.InRange(0, 1000));
        }
    }
}