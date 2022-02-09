namespace StarBuzzLib
{
    public class Espresso : IBeverage
    {
        private string description;

        public Espresso(string description) { this.description = description; }

        public string GetDescription() { return description; }

        public decimal Cost() { return 1.99M; }
    }
}