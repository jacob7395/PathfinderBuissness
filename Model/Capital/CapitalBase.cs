namespace PathfinderBuissness.Model.Capital
{
    public abstract class CapitalBase
    {
        public int Quantity = 0;

        public CapitalBase(int quantity)
        {
            Quantity = quantity;
        }
    }
}
