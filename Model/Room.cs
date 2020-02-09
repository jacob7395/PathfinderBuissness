using PathfinderBuissness.Model.Capital;

namespace PathfinderBuissness.Model
{
    public class Room
    {
        public string Name { get; set; } = "New Room";
        public Cost Cost = new Cost();
        public Earning Earning = new Earning();
        public int ConstructionTime = 0;
    }
}
