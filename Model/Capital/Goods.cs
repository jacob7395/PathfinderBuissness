namespace PathfinderBuissness.Model.Capital
{
    public class Goods : CapitalBase
    {
        public const int PurchaseCost = 20;
        public const int EarnedCost = 10;

        public Goods(int quantity) : base(quantity)
        {
        }
    }
}
