namespace StarBuzzLib
{
    public abstract class Beverage
    {
        protected string description;
        
        public abstract decimal Cost();
        public abstract string GetDescription();
    }
}
