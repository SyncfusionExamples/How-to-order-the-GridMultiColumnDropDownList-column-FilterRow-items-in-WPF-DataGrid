# How to order the GridMultiColumnDropDownList column FilterRow items in WPF DataGrid (SfDataGrid)

The ComboBox for FilterRow will be loaded with items based on the records order in the [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid). In order to sort the items in ComboBox of FilterRow, CustomCellRenderer can be derived from the [GridFilterRowMultiSelectRenderer](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.RowFilter.GridFilterRowMultiSelectRenderer.html?_gl=1*qeaft4*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2OTcyMzQ0My4zMjIuMS4xNjY5NzIzOTQ5LjAuMC4w&_ga=2.121555663.696256746.1669612014-766490130.1650530957) and adding the custom renderer to the grid.

```
public class GridMultiSelectComboBoxRendererExt : GridFilterRowMultiSelectRenderer
{
    public GridMultiSelectComboBoxRendererExt() : base()
    {
    }
 
    public override void OnInitializeEditElement(DataColumnBase dataColumn, ComboBoxAdv uiElement, object dataContext)
    {
        //To sort the items while the DropDown for filter cell is initialized.
        base.OnInitializeEditElement(dataColumn, uiElement, dataContext);
        SortDescription sd = new SortDescription("DisplayText", ListSortDirection.Ascending);
        uiElement.Items.SortDescriptions.Add(sd);
    }
}
```

```
//Remove the existing renderer
Grid.FilterRowCellRenderers.Remove("MultiSelectComboBox");
//Add the customized renderer
Grid.FilterRowCellRenderers.Add("MultiSelectComboBox", new GridMultiSelectComboBoxRendererExt());
```
