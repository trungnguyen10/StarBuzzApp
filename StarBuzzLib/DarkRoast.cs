namespace StarBuzzLib
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(string description) { this.description = description; }

        public override string GetDescription() { return this.description; }

        public override decimal Cost() { return 0.99M; }
    }
}