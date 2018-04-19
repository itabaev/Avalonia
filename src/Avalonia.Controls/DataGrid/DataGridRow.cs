using System.Linq;
using Avalonia.Controls.Mixins;
using Avalonia.Controls.Primitives;

namespace Avalonia.Controls
{
    public class DataGridRow : TemplatedControl, ISelectable
    {
        /// <summary>
        /// Defines the <see cref="Item"/> property.
        /// </summary>
        public static readonly DirectProperty<DataGridRow, object> ItemProperty =
            AvaloniaProperty.RegisterDirect<DataGridRow, object>(nameof(Item), o => o.Item, (o, v) => o.Item = v);

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
            ItemProperty.Changed.AddClassHandler<DataGridRow>(x => x.OnItemChanged);
        }

        private DataGrid _dataGrid;
        private ItemsControl _contentPresenter;
        private object _item;

        #region Properties

        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        public object Item
        {
            get { return _item; }
            set { SetAndRaise(ItemProperty, ref _item, value); }
        }

        /// <summary>
        /// Gets or sets the selection state of the item.
        /// </summary>
        public bool IsSelected
        {
            get { return GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        #endregion

        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            base.OnTemplateApplied(e);
            _contentPresenter = e.NameScope.Find<ItemsControl>("PART_ContentPresenter");
            UpdatePresenterItems();
        }

        #region Visual

        protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnAttachedToVisualTree(e);
            _dataGrid = this.FindParent<DataGrid>();
            UpdatePresenterItems();
        }

        protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
        {
            base.OnDetachedFromVisualTree(e);
            _dataGrid = null;
            UpdatePresenterItems();
        }

        #endregion

        private void OnItemChanged(AvaloniaPropertyChangedEventArgs e)
        {
            UpdatePresenterItems();
        }

        private void UpdatePresenterItems()
        {
            if (_contentPresenter == null)
                return;

            if (_dataGrid == null)
            {
                _contentPresenter.Items = null;
                return;
            }

            _contentPresenter.Items = Enumerable.Repeat(Item, _dataGrid.Columns.Count).ToList().AsReadOnly();
        }
    }
}