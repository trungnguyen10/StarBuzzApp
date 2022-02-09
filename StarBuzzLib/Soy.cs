namespace StarBuzzLib
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) {this.Wrappee = beverage;}

        public override string GetDescription()
        {
            return Wrappee.GetDescription() + ", Soy";
        }

        public override decimal Cost()
        {
            return Wrappee.Cost() + 0.15M;
        }
    }
}