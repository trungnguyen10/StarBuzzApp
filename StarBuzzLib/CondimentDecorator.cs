namespace StarBuzzLib
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Wrappee { get; set; }

        public abstract override string GetDescription();

        public abstract override decimal Cost();
    }
}