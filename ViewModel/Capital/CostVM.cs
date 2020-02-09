using PathfinderBuissness.Model.Capital;
using PathfinderBuissness.Tools;

namespace PathfinderBuissness.ViewModel.Capital
{
    public class CostVM : ObservableObject
    {
        private Cost model;

        public int Goods
        {
            get => model.Goods.Quantity;
            set
            {
                model.Goods.Quantity = value;
                OnPropertyChanged(() => Goods);
            }
        }
        public int Influence
        {
            get => model.Influence.Quantity;
            set
            {
                model.Influence.Quantity = value;
                OnPropertyChanged(() => Influence);
            }
        }
        public int Labor
        {
            get => model.Labor.Quantity;
            set
            {
                model.Labor.Quantity = value;
                OnPropertyChanged(() => Labor);
            }
        }
        public int Magic
        {
            get => model.Magic.Quantity;
            set
            {
                model.Goods.Quantity = value;
                OnPropertyChanged(() => Magic);
            }
        }
        public int Time
        {
            get => model.Time;
            set
            {
                model.Time = value;
                OnPropertyChanged(() => Goods);
            }
        }

        public CostVM(Cost model)
        {
            this.model = model;
        }
    }
}
