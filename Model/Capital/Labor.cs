namespace PathfinderBuissness.Model.Capital
{
    public class Labor : CapitalBase
    {
        public const int PurchaseCost = 20;
        public const int EarnedCost = 10;

        public Labor(int quantity) : base(quantity)
        {
        }
    }
}
