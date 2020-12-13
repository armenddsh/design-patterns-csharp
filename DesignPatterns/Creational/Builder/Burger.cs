using System;
using System.Text;

namespace design_patterns_csharp.Creational.Builder
{
    public enum BURGER_SIZE
    {
        SMALL,
        MEDIUM,
        LARGE,
        EXTRA_LARGE
    }
    public partial class Burger
    {
        private readonly BURGER_SIZE size;
        private readonly bool cheese;
        private readonly bool peperoni;
        private readonly bool lettuce;
        private readonly bool tomato;

        public Burger(BurberBuilder builder)
        {
            this.size = builder.size;
            this.cheese = builder.cheese;
            this.peperoni = builder.peperoni;
            this.lettuce = builder.lettuce;
            this.tomato = builder.tomato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Burger size: " + size + Environment.NewLine);
            if (cheese)
            {
                sb.Append("+ Cheese" + Environment.NewLine);
            }

            if (peperoni)
            {
                sb.Append("+ Peperoni" + Environment.NewLine);
            }

            if (lettuce)
            {
                sb.Append("+ Lettuce" + Environment.NewLine);
            }

            if (tomato)
            {
                sb.Append("+ Tomato" + Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
