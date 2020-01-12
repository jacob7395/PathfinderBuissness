using PathfinderBuissness.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Threading;

namespace PathfinderBuissness
{
    class Program
    {
        public ObservableCollection<Building> buildings { get; set; } = new ObservableCollection<Building>();

        private Dispatcher _Dispatcher;
        public Program(Dispatcher dispatcher)
        {
            _Dispatcher = dispatcher;
        }

    }
}
