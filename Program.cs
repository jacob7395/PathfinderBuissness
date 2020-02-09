using PathfinderBuissness.Model;
using PathfinderBuissness.Tools;
using PathfinderBuissness.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Threading;

namespace PathfinderBuissness
{
    class Program : ObservableObject
    {
        public ObservableCollection<Building> buildings { get; set; } = new ObservableCollection<Building>();

        private Dispatcher _Dispatcher;
        private IPanel selectedPanel;

        public IPanel SelectedPanel
        {
            get => selectedPanel;
            set
            {
                selectedPanel = value;
                OnPropertyChanged(() => SelectedPanel);
            }
        }
        public Program(Dispatcher dispatcher)
        {
            _Dispatcher = dispatcher;
            SelectedPanel = new BuildingVM(new Building());
        }
    }
}
