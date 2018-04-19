using System;
using Avalonia.Controls.Generators;

namespace Avalonia.Controls
{
    public class DataGridRowContainerGenerator : ItemContainerGenerator
    {
        public DataGridRowContainerGenerator(IControl owner) : base(owner)
        {
        }

        /// <inheritdoc/>
        public override Type ContainerType => typeof(DataGridRow);

        /// <inheritdoc/>
        protected override IControl CreateContainer(object item)
        {
            var container = item as DataGridRow;

            if (item == null)
            {
                return null;
            }
            else if (container != null)
            {
                return container;
            }
            else
            {
                var result = new DataGridRow
                {
                    Item = item
                };

                if (!(item is IControl))
                {
                    result.DataContext = item;
                }

                return result;
            }
        }
    }
}
