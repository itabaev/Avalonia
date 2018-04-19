using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Avalonia.Controls.Generators;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Controls.Utils;
using Avalonia.Input;

namespace Avalonia.Controls
{
    public class DataGrid : SelectingItemsControl
    {
        #region Static properties

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

        public static readonly AvaloniaProperty<ObservableCollection<DataGridColumn>> ColumnsProperty =
            AvaloniaProperty.RegisterDirect<DataGrid, ObservableCollection<DataGridColumn>>(nameof(Columns), o => o.Columns);

        /// <summary>
        /// Defines the <see cref="AutoGenerateColumns"/> property.
        /// </summary>
        public static readonly StyledProperty<bool> AutoGenerateColumnsProperty =
            AvaloniaProperty.Register<DataGrid, bool>(nameof(AutoGenerateColumns), true);

        /// <summary>
        /// Initializes static members of the <see cref="ItemsControl"/> class.
        /// </summary>
        static DataGrid()
        {
            ItemsPanelProperty.OverrideDefaultValue<DataGrid>(DefaultPanel);
            VirtualizationModeProperty.OverrideDefaultValue<DataGrid>(ItemVirtualizationMode.Simple);
        }

        #endregion

        public DataGrid()
        {
            Columns = new ObservableCollection<DataGridColumn>();
            Columns.CollectionChanged += OnColumnsCollectionChanged;
        }

        #region Properties

        private IScrollable _scroll;
        private ObservableCollection<DataGridColumn> _columns;

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

        public ObservableCollection<DataGridColumn> Columns
        {
            get { return _columns; }
            private set { SetAndRaise(ColumnsProperty, ref _columns, value); }
        }

        /// <summary>
        /// The property which determines whether the columns are to be auto generated or not.
        /// </summary>
        public bool AutoGenerateColumns
        {
            get { return GetValue(AutoGenerateColumnsProperty); }
            set { SetValue(AutoGenerateColumnsProperty, value); }
        }

        #endregion

        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            base.OnTemplateApplied(e);
            Scroll = e.NameScope.Find<IScrollable>("PART_ScrollViewer");
        }

        /// <inheritdoc/>
        protected override IItemContainerGenerator CreateItemContainerGenerator()
        {
            return new DataGridRowContainerGenerator(this);
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

        /// <inheritdoc/>
        protected override void ItemsChanged(AvaloniaPropertyChangedEventArgs e)
        {
            base.ItemsChanged(e);

            if (Items == null)
                return;

            if (AutoGenerateColumns)
            {
                AddAutoColumns();
            }
        }

        /// <inheritdoc/>
        protected override void ItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            base.ItemsCollectionChanged(sender, e);
        }

        private void OnColumnsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ColumnsCollectionChanged(sender, e);
        }

        protected virtual void ColumnsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
        }

        private void AddAutoColumns()
        {
            var itemProperties = Items.GetItemProperties();
            if (itemProperties?.Any() == true)
            {
                foreach (var itemProperty in itemProperties)
                {
                    var dataGridColumn = CreateColumn(itemProperty);

                    if (dataGridColumn != null)
                    {
                        dataGridColumn.IsAutoGenerated = true;
                        Columns.Add(dataGridColumn);
                    }
                }
            }
        }

        protected virtual DataGridColumn CreateColumn(ItemPropertyInfo itemProperty)
        {
            DataGridColumn dataGridColumn;
            var propertyType = Nullable.GetUnderlyingType(itemProperty.PropertyType) ?? itemProperty.PropertyType;

            // determine the type of column to be created and create one
            if (propertyType.IsEnum)
            {
                var comboBoxColumn = new DataGridComboBoxColumn(itemProperty);
                //TODO ItemsSource
                //comboBoxColumn.ItemsSource = Enum.GetValues(propertyType);
                dataGridColumn = comboBoxColumn;
            }
            else if (typeof(string).IsAssignableFrom(propertyType))
            {
                dataGridColumn = new DataGridTextColumn(itemProperty);
            }
            else if (typeof(bool).IsAssignableFrom(propertyType))
            {
                dataGridColumn = new DataGridCheckBoxColumn(itemProperty)
                {
                    IsThreeState = Nullable.GetUnderlyingType(itemProperty.PropertyType) != null
                };
            }
            else if (typeof(Uri).IsAssignableFrom(propertyType))
            {
                dataGridColumn = new DataGridHyperlinkColumn(itemProperty);
            }
            else
            {
                dataGridColumn = new DataGridTextColumn(itemProperty);
            }

            dataGridColumn.Header = itemProperty.Name;

            //TODO CanUserSort
            // determine if the datagrid can sort on the column or not
            //if (!typeof(IComparable).IsAssignableFrom(propertyType))
            //{
            //    dataGridColumn.CanUserSort = false;
            //}

            //TODO Binding and IsReadOnly
            // Set the data field binding for such created columns and
            // choose the BindingMode based on editability of the property.
            //DataGridBoundColumn boundColumn = dataGridColumn as DataGridBoundColumn;
            //if (boundColumn != null || comboBoxColumn != null)
            //{
            //    Binding binding = new Binding(itemProperty.Name);
            //    if (comboBoxColumn != null)
            //    {
            //        comboBoxColumn.SelectedItemBinding = binding;
            //    }
            //    else
            //    {
            //        boundColumn.Binding = binding;
            //    }

            //    PropertyDescriptor pd = itemProperty.Descriptor as PropertyDescriptor;
            //    if (pd != null)
            //    {
            //        if (pd.IsReadOnly)
            //        {
            //            binding.Mode = BindingMode.OneWay;
            //            dataGridColumn.IsReadOnly = true;
            //        }
            //    }
            //    else
            //    {
            //        PropertyInfo pi = itemProperty.Descriptor as PropertyInfo;
            //        if (pi != null)
            //        {
            //            if (!pi.CanWrite)
            //            {
            //                binding.Mode = BindingMode.OneWay;
            //                dataGridColumn.IsReadOnly = true;
            //            }
            //        }
            //    }
            //}

            return dataGridColumn;
        }
    }
}
