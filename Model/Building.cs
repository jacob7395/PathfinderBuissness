using PathfinderBuissness.Model.Capital;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathfinderBuissness.Model
{
    public class Building
    {
        public string Name = "New Building";
        public BuildStates BuildStates;
        public IEnumerable<Room> Rooms => _rooms.ToList();
        public Cost Cost => claculateCost(room => room.Cost);
        public Cost Earnings => claculateCost(room => room.Earning);

        private List<Room> _rooms { get; set; } = new List<Room>();
        public Building()
        {
            Room Room = new Room();
            Room.Cost.Goods.Quantity = 50;
            Room.Cost.Influence.Quantity = 25;
            Room.Cost.Magic.Quantity = 5;
            Room.Cost.Labor.Quantity = 75;

            _rooms.Add(Room);
        }

        private Cost claculateCost(Func<Room, Cost> getCost)
        {
            Cost totalCost = new Cost();
            _rooms.ForEach(room => totalCost += getCost(room));
            return totalCost;
        }

        public void AddRoom() => _rooms.Add(new Room());
        public void RemoveRoom() => _rooms.Remove(new Room());
    }
}
