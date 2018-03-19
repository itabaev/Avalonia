namespace Avalonia.Controls
{
    public class DataGridCellsPanel : VirtualizingStackPanel
    {
        static DataGridCellsPanel()
        {
            OrientationProperty.OverrideDefaultValue<DataGridCellsPanel>(Orientation.Horizontal);
        }
    }
}
