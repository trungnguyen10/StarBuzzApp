namespace StarBuzzLib
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(string description) {this.description = description;}

        public override string GetDescription() {return this.description;}

        public override decimal Cost() {return .89M;}
    }
}