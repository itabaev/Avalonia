using Avalonia.Controls.Mixins;

namespace Avalonia.Controls
{
    public class DataGridRow : ContentControl, ISelectable
    {
        /// <summary>
        /// Defines the <see cref="IsSelected"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> IsSelectedProperty =
            AvaloniaProperty.Register<DataGridRow, bool>(nameof(IsSelected));

        /// <summary>
        /// Initializes static members of the <see cref="DataGridRow"/> class.
        /// </summary>
        static DataGridRow()
        {
            SelectableMixin.Attach<DataGridRow>(IsSelectedProperty);
            FocusableProperty.OverrideDefaultValue<DataGridRow>(true);
        }

        /// <summary>
        /// Gets or sets the selection state of the item.
        /// </summary>
        public bool IsSelected
        {
            get { return GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
    }
}