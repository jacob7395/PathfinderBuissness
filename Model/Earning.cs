using PathfinderBuissness.Model.Capital;

namespace PathfinderBuissness.Model
{
    public class Earning : Cost
    {
        public Earning() { }

        public Earning(int goods, int influence, int labor, int magic, int time) : base(goods, influence, labor, magic, time)
        {
        }
    }
}