namespace PathfinderBuissness.Model.Capital
{
    public class Influence : CapitalBase
    {
        public const int PurchaseCost = 30;
        public const int EarnedCost = 15;

        public Influence(int quantity) : base(quantity)
        {
        }
    }
}
