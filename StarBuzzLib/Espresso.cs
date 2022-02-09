namespace StarBuzzLib
{
    public class Espresso : Beverage
    {
        public Espresso(string description) { this.description = description; }

        public override string GetDescription() { return description; }

        public override decimal Cost() { return 1.99M; }
    }
}