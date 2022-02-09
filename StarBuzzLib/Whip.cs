namespace StarBuzzLib
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) {this.Wrappee = beverage;}

        public override string GetDescription()
        {
            return Wrappee.GetDescription() + ", Whip";
        }

        public override decimal Cost()
        {
            return Wrappee.Cost() + 0.10M;
        }
    }
}