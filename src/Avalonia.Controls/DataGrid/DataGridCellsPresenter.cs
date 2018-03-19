using Avalonia.Controls.Generators;
using Avalonia.Controls.Templates;

namespace Avalonia.Controls
{
    public class DataGridCellsPresenter : ItemsControl
    {
        /// <summary>
        /// The default value for the <see cref="ItemsControl.ItemsPanel"/> property.
        /// </summary>
        private static readonly FuncTemplate<IPanel> DefaultPanel =
            new FuncTemplate<IPanel>(() => new DataGridCellsPanel());

        static DataGridCellsPresenter()
        {
            ItemsPanelProperty.OverrideDefaultValue<DataGridCellsPresenter>(DefaultPanel);
        }

        /// <inheritdoc/>
        protected override IItemContainerGenerator CreateItemContainerGenerator()
        {
            return new ItemContainerGenerator<DataGridCell>(
                this,
                DataGridCell.ContentProperty,
                DataGridCell.ContentTemplateProperty);
        }
    }
}
