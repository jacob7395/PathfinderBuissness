using System;

namespace PathfinderBuissness.Model.Capital
{
    public class CapitalCollection
    {
        public Goods Goods;
        public Influence Influence;
        public Labor Labor;
        public Magic Magic;
        public int Time;
        public int GP => calcGP_Value();


        public CapitalCollection(int goods, int influence, int labor, int magic, int time)
        {
            Goods = new Goods(goods);
            Influence = new Influence(influence);
            Labor = new Labor(labor);
            Magic = new Magic(magic);
            Time = time;
        }
        private int calcGP_Value()
        {
            int cost = 0;
            cost += Goods.PurchaseCost;
            cost += Influence.PurchaseCost;
            cost += Labor.PurchaseCost;
            cost += Magic.PurchaseCost;
            return cost;
        }
    }
}