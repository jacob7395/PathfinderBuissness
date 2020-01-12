using PathfinderBuissness.Model.Capital;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderBuissness.Model
{
    public class Buissness
    {
        public string guid = new Guid().ToString();
        public List<Building> Building = new List<Building>();
    }
}
