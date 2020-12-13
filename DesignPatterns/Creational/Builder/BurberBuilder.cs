namespace design_patterns_csharp.Creational.Builder
{
    public partial class Burger
    {
        public class BurberBuilder
        {
            public BURGER_SIZE size;
            public bool cheese;
            public bool peperoni;
            public bool lettuce;
            public bool tomato;

            public BurberBuilder(BURGER_SIZE size)
            {
                this.size = size;
            }

            public BurberBuilder AddCheese()
            {
                this.cheese = true;
                return this;
            }

            public BurberBuilder AddPeperoni()
            {
                this.peperoni = true;
                return this;
            }

            public BurberBuilder AddLettuce()
            {
                this.lettuce = true;
                return this;
            }

            public BurberBuilder AddTomato()
            {
                this.tomato = true;
                return this;
            }

            public Burger Build()
            {
                return new Burger(this);
            }
        }
    }
}
