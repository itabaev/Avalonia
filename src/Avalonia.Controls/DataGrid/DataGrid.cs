using System.Collections;
using Avalonia.Controls.Generators;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Input;

namespace Avalonia.Controls
{
    public class DataGrid : SelectingItemsControl
    {
        /// <summary>
        /// The default value for the <see cref="ItemsControl.ItemsPanel"/> property.
        /// </summary>
        private static readonly FuncTemplate<IPanel> DefaultPanel =
            new FuncTemplate<IPanel>(() => new VirtualizingStackPanel());

        /// <summary>
        /// Defines the <see cref="Scroll"/> property.
        /// </summary>
        public static readonly DirectProperty<DataGrid, IScrollable> ScrollProperty =
            AvaloniaProperty.RegisterDirect<DataGrid, IScrollable>(nameof(Scroll), o => o.Scroll);

        /// <summary>
        /// Defines the <see cref="SelectedItems"/> property.
        /// </summary>
        public new static readonly AvaloniaProperty<IList> SelectedItemsProperty =
            SelectingItemsControl.SelectedItemsProperty;

        /// <summary>
        /// Defines the <see cref="SelectionMode"/> property.
        /// </summary>
        public new static readonly AvaloniaProperty<SelectionMode> SelectionModeProperty =
            SelectingItemsControl.SelectionModeProperty;

        /// <summary>
        /// Defines the <see cref="VirtualizationMode"/> property.
        /// </summary>
        public static readonly StyledProperty<ItemVirtualizationMode> VirtualizationModeProperty =
            ItemsPresenter.VirtualizationModeProperty.AddOwner<DataGrid>();

        private IScrollable _scroll;

        /// <summary>
        /// Initializes static members of the <see cref="ItemsControl"/> class.
        /// </summary>
        static DataGrid()
        {
            ItemsPanelProperty.OverrideDefaultValue<DataGrid>(DefaultPanel);
            VirtualizationModeProperty.OverrideDefaultValue<DataGrid>(ItemVirtualizationMode.Simple);
        }

        /// <summary>
        /// Gets the scroll information for the <see cref="DataGrid"/>.
        /// </summary>
        public IScrollable Scroll
        {
            get { return _scroll; }
            private set { SetAndRaise(ScrollProperty, ref _scroll, value); }
        }

        /// <inheritdoc/>
        public new IList SelectedItems => base.SelectedItems;

        /// <inheritdoc/>
        public new SelectionMode SelectionMode
        {
            get { return base.SelectionMode; }
            set { base.SelectionMode = value; }
        }

        /// <summary>
        /// Gets or sets the virtualization mode for the items.
        /// </summary>
        public ItemVirtualizationMode VirtualizationMode
        {
            get { return GetValue(VirtualizationModeProperty); }
            set { SetValue(VirtualizationModeProperty, value); }
        }

        /// <inheritdoc/>
        protected override IItemContainerGenerator CreateItemContainerGenerator()
        {
            return new ItemContainerGenerator<DataGridRow>(
                this,
                DataGridRow.ContentProperty,
                DataGridRow.ContentTemplateProperty);
        }

        /// <inheritdoc/>
        protected override void OnGotFocus(GotFocusEventArgs e)
        {
            base.OnGotFocus(e);

            if (e.NavigationMethod == NavigationMethod.Directional)
            {
                e.Handled = UpdateSelectionFromEventSource(
                    e.Source,
                    true,
                    (e.InputModifiers & InputModifiers.Shift) != 0);
            }
        }

        /// <inheritdoc/>
        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            base.OnPointerPressed(e);

            if (e.MouseButton == MouseButton.Left || e.MouseButton == MouseButton.Right)
            {
                e.Handled = UpdateSelectionFromEventSource(
                    e.Source,
                    true,
                    (e.InputModifiers & InputModifiers.Shift) != 0,
                    (e.InputModifiers & InputModifiers.Control) != 0);
            }
        }

        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            base.OnTemplateApplied(e);
            Scroll = e.NameScope.Find<IScrollable>("PART_ScrollViewer");
        }
    }
}
