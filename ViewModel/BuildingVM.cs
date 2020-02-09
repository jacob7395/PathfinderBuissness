using PathfinderBuissness.Model;
using PathfinderBuissness.Tools;
using PathfinderBuissness.ViewModel.Capital;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PathfinderBuissness.ViewModel
{
    class BuildingVM : ObservableObject, IPanel
    {

        public HeaderVM Name { get; }
        public BuildStates BuildStates => _model.BuildStates;
        public ObservableCollection<Room> Rooms => new ObservableCollection<Room>(_model.Rooms);
        public CostVM Cost => new CostVM(_model.Cost);
        public CostVM Earnings => new CostVM(_model.Earnings);
        private Building _model { get; }
        public BuildingVM(Building model)
        {
            this._model = model;

            Name = new HeaderVM(() => _model.Name, (value) => { _model.Name = value; });
        }

        public void AddRoom() => _model.AddRoom();
        public void RemoveRoom() => _model.RemoveRoom();
    }

    class HeaderVM : ObservableObject
    {
        private readonly Func<string> getValue;
        private readonly Action<string> setValue;

        public bool NameReadOnly { get; private set; } = false;
        public string Name
        {
            get => getValue();
            set
            {
                setValue(value);
                OnPropertyChanged(() => Name);
            }
        }
        public ICommand EditNameToggle { get; }

        public HeaderVM(Func<string> getValue, Action<string> setValue) 
        {
            this.getValue = getValue;
            this.setValue = setValue;

            EditNameToggle = new RelayCommand(o => { NameReadOnly = !NameReadOnly; });
        }
    }
}
