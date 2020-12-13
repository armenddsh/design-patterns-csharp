using design_patterns_csharp.Creational.Builder;
using Xunit;

namespace DesignPatterns.Test.Creational
{
    public class Builder
    {

        [Fact]
        public void BuilderTest()
        {
            Burger burger = new Burger.BurberBuilder(BURGER_SIZE.MEDIUM)
                .AddCheese()
                .AddPeperoni()
                .AddTomato()
                .Build();

            Assert.NotNull(burger);

            Assert.Equal("Burger size: MEDIUM\r\n+ Cheese\r\n+ Peperoni\r\n+ Tomato\r\n", burger.ToString());
        }
    }
}
