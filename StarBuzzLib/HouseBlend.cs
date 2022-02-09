namespace StarBuzzLib
{
    public class HouseBlend : IBeverage
    {
        private string description;

        public HouseBlend(string description) {this.description = description;}

        public string GetDescription() {return this.description;}

        public decimal Cost() {return .89M;}
    }
}