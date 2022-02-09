namespace StarBuzzLib
{
    public abstract class CondimentDecorator : IBeverage
    {
        public IBeverage Wrappee {get; set;}

        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}