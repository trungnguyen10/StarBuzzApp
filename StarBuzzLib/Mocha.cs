namespace StarBuzzLib
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage) { this.Wrappee = beverage; }

        public override string GetDescription()
        {
            return Wrappee.GetDescription() + ", Mocha";
        }

        public override decimal Cost()
        {
            return Wrappee.Cost() + .20M;
        }
    }
}