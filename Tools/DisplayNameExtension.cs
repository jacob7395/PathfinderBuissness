using PathfinderBuissness.ViewModel;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Markup;

namespace PathfinderBuissness.Tools
{
    // Example use of this class
    /*    <DataTemplate x:Key="NamedInputBox">
        <Grid>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width= "5"/>
                <ColumnDefinition Width= "Auto" SharedSizeGroup="PropertyCol"/>
                <ColumnDefinition Width= "15"/>
                <ColumnDefinition/>
                <ColumnDefinition Width= "5"/>
            </Grid.ColumnDefinitions>
            <TextBlock Grid.Column="1" Text="{m:DisplayName Name, Type=Binding}"/>
            <TextBox Grid.Column="3" Text="{Binding Name}" TextAlignment="Left"/>
        </Grid>
    </DataTemplate>

        [DisplayName("RenamedProperty")]
        public string Name 
        {
            get => _model.Name;
            set
            {
                _model.Name = value;
                OnPropertyChanged(() => Name);
            }
        }
    */

    public class DisplayNameExtension : MarkupExtension
    {
        public Type Type { get; set; }
        public string PropertyName { get; set; }

        public DisplayNameExtension() { }
        public DisplayNameExtension(string propertyName)
        {
            PropertyName = propertyName;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            // (This code has zero tolerance)
            PropertyInfo prop = typeof(BuildingVM).GetProperty(PropertyName);
            var attributes = prop.GetCustomAttributes(typeof(DisplayNameAttribute), false);
            return (attributes[0] as DisplayNameAttribute).DisplayName;
        }
    }
}
