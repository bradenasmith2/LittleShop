namespace LittleShop
{
    public class item_tests
    {
        [Fact]
        public void Item_Constructor_SetsCorrectPropertyValues()//Unit Test
        {
            Item item = new("item name", 25);

            Assert.Equal("item name", item.Name);
            Assert.Equal(25, item.Price);
        }
    }
}