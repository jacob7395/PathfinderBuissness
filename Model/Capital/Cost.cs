using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace PathfinderBuissness.Model.Capital
{
    public class Cost : IEquatable<Cost>
    {
        public Goods Goods = new Goods(0);
        public Influence Influence = new Influence(0);
        public Labor Labor = new Labor(0);
        public Magic Magic = new Magic(0);
        public int Time = 0;
        public int GP => calcGP_Value();

        public Cost() { }
        public Cost(int goods, int influence, int labor, int magic, int time)
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
            cost += Goods.PurchaseCost * Goods.Quantity;
            cost += Influence.PurchaseCost * Influence.Quantity;
            cost += Labor.PurchaseCost * Labor.Quantity;
            cost += Magic.PurchaseCost * Magic.Quantity;
            return cost;
        }

        public override bool Equals(object? obj)
        {
            return obj is Cost collection &&
                   EqualityComparer<Goods>.Default.Equals(Goods, collection.Goods) &&
                   EqualityComparer<Influence>.Default.Equals(Influence, collection.Influence) &&
                   EqualityComparer<Labor>.Default.Equals(Labor, collection.Labor) &&
                   EqualityComparer<Magic>.Default.Equals(Magic, collection.Magic) &&
                   Time == collection.Time &&
                   GP == collection.GP;
        }

        public bool Equals([AllowNull] Cost other)
        {
            return other != null &&
                   EqualityComparer<Goods>.Default.Equals(Goods, other.Goods) &&
                   EqualityComparer<Influence>.Default.Equals(Influence, other.Influence) &&
                   EqualityComparer<Labor>.Default.Equals(Labor, other.Labor) &&
                   EqualityComparer<Magic>.Default.Equals(Magic, other.Magic) &&
                   Time == other.Time &&
                   GP == other.GP;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Goods, Influence, Labor, Magic, Time, GP);
        }

        public static bool operator ==(Cost left, Cost right)
        {
            return EqualityComparer<Cost>.Default.Equals(left, right);
        }

        public static bool operator !=(Cost left, Cost right)
        {
            return !(left == right);
        }
        public static Cost operator +(Cost left, Cost right)
        {
            return new Cost(left.Goods.Quantity + right.Goods.Quantity,
                            left.Influence.Quantity + right.Influence.Quantity,
                            left.Labor.Quantity + right.Labor.Quantity,
                            left.Magic.Quantity + right.Magic.Quantity,
                            left.Time + right.Time);
        }
    }
}