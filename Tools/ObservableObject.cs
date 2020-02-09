using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace PathfinderBuissness.Tools
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler == null)
            {
                return;
            }

            handler(this, new PropertyChangedEventArgs(name));
        }

        public void OnPropertyChanged(Expression<Func<object>> expression)
        {
            if (!(expression is LambdaExpression))
            {
                throw new ArgumentException("Expressions is not of LamabdaExpression type");
            }

            LambdaExpression property = expression;
            MemberExpression memberExpression;
            if (property.Body is MemberExpression)
            {
                memberExpression = (MemberExpression)property.Body;
            }
            else
            {
                UnaryExpression unaryExpression = (UnaryExpression)property.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            OnPropertyChanged((memberExpression).Member.Name);
        }
    }
}