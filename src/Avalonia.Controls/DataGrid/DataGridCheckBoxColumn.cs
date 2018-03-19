namespace Avalonia.Controls
{
    public class DataGridCheckBoxColumn : DataGridColumn
    {
        public static readonly StyledProperty<bool> IsThreeStateProperty =
            AvaloniaProperty.Register<DataGridCheckBoxColumn, bool>(nameof(IsThreeState));

        public DataGridCheckBoxColumn(ItemPropertyInfo itemProperty) : base(itemProperty)
        {
        }

        public bool IsThreeState
        {
            get { return GetValue(IsThreeStateProperty); }
            set { SetValue(IsThreeStateProperty, value); }
        }
    }
}
