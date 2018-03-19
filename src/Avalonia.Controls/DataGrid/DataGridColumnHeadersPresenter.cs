﻿using Avalonia.Controls.Generators;
using Avalonia.Controls.Templates;

namespace Avalonia.Controls
{
    public class DataGridColumnHeadersPresenter : ItemsControl
    {
        /// <summary>
        /// The default value for the <see cref="ItemsControl.ItemsPanel"/> property.
        /// </summary>
        private static readonly FuncTemplate<IPanel> DefaultPanel =
            new FuncTemplate<IPanel>(() => new DataGridCellsPanel());

        static DataGridColumnHeadersPresenter()
        {
            ItemsPanelProperty.OverrideDefaultValue<DataGridColumnHeadersPresenter>(DefaultPanel);
        }

        /// <inheritdoc/>
        protected override IItemContainerGenerator CreateItemContainerGenerator()
        {
            return new ItemContainerGenerator<DataGridColumnHeader>(
                this,
                DataGridColumnHeader.ContentProperty,
                DataGridColumnHeader.ContentTemplateProperty);
        }
    }
}
