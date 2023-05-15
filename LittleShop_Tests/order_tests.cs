namespace LittleShop
{
    public class order_tests
    {
        [Fact]
        public void Order_Constructor_SetsCorrectPropertyValues()//Unit Test
        {
            Customer customer = new("name", "address");
            List<Item> itemList = new List<Item>();

            Order order = new(customer);

            Assert.Equal(itemList, order.Items);
            //Assert.Equal("name", order.Customer[0]);
            Assert.Equal(customer, order.Customer);
            Assert.Equal("name", order.Customer.Name);
        }

        [Fact]
        public void Order_AddToOrder_AddsItemsToCustomerOrder()//Unit Test
        {
            Item item = new("name of item", 25);
            Item item2 = new("name of item2", 50);
            Customer customer = new("name", "address");
            Order order = new(customer);

            List<Item> expectedValueList = new List<Item>();
            expectedValueList.Add(item);
            expectedValueList.Add(item2);

            order.AddToOrder(item);
            order.AddToOrder(item2);

            Assert.Equal(expectedValueList, order.Items);
        }

        [Fact]
        public void Order_Total_AddsPriceOfAllItemsInCustomerOrder()//Integration Test
        {
            Item item = new("name of item", 25);
            Item item2 = new("name of item2", 50);
            Customer customer = new("name", "address");
            Order order = new(customer);

            order.AddToOrder(item);
            order.AddToOrder(item2);

            Assert.Equal(75, order.Total());
        }
    }
}