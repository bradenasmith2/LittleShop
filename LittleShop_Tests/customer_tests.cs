namespace LittleShop
{
    public class customer_tests
    {
        [Fact]
        public void Customer_Constructor_SetsCorrectPropertyValues()//Unit Test
        {
            Customer customer = new("customer name", "customer address");

            Assert.Equal("customer name", customer.Name);
            Assert.Equal("customer address", customer.Address);
        }
    }
}