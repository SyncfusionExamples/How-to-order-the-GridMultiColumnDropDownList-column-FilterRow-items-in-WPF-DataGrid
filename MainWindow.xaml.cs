#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EditingAndDataValidation.DataModel;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EditingAndDataValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()

        {
            InitializeComponent();
            Grid.CellRenderers.Remove("MultiColumnDropDown");
            Grid.CellRenderers.Add("MultiColumnDropDown", new CustomMultiColumnDropDownRenderer());
            Grid.FilterRowCellRenderers.Remove("MultiSelectComboBox");
            Grid.FilterRowCellRenderers.Add("MultiSelectComboBox", new GridMultiSelectComboBoxRendererExt());
        }
    }

    public class CustomMultiColumnDropDownRenderer : GridCellMultiColumnDropDownRenderer
    {
        protected override SfMultiColumnDropDownControl OnCreateEditUIElement()
        {
            return new CustomMultiColumnDropDownControl(DataGrid);
        }

        public override void OnInitializeDisplayElement(DataColumnBase dataColumn, TextBlock uiElement, object dataContext)
        {
            var gridColumn = dataColumn.GridColumn as GridMultiColumnDropDownList;
            var itemsSource = gridColumn.ItemsSource as ObservableCollection<ProductInfo>;
            var record = dataContext as OrderInfo;
            if (!(itemsSource.Any(info => info.Code == record.ProductCode)))
                itemsSource.Add(new ProductInfo() { Code = record.ProductCode });

            base.OnInitializeDisplayElement(dataColumn, uiElement, dataContext);
        }
        protected override bool ShouldGridTryToHandleKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var multiDropDown = (CurrentCellRendererElement as CustomMultiColumnDropDownControl);
                multiDropDown.AddItem(multiDropDown);
            }
            return base.ShouldGridTryToHandleKeyDown(e);
        }
    }

    public class CustomMultiColumnDropDownControl : SfMultiColumnDropDownControl
    {
        SfDataGrid DataGrid;
        public CustomMultiColumnDropDownControl(SfDataGrid dataGrid) : base()
        {
            DataGrid = dataGrid;
        }
        public override void OnApplyTemplate()
        {
            Editor = GetTemplateChild("PART_TextBox") as TextBox;
            if (Editor != null)
                Editor.LostFocus += Editor_LostFocus;
            base.OnApplyTemplate();

        }
        private void Editor_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                AddItem(this);
            }
        }

        internal void AddItem(SfMultiColumnDropDownControl multiDropDown)
        {
            var textBox = multiDropDown.GetType().GetProperty("Editor", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(multiDropDown);
            var newValue = textBox != null ? (textBox as TextBox).Text : null;
            var underlyingItems = ((multiDropDown as CustomMultiColumnDropDownControl).DataGrid.DataContext as ViewModel).ProductList;

            if (underlyingItems != null)
            {
                bool newRecord = underlyingItems.Any(x => x.Code == newValue.ToString());
                if (!newRecord)
                {
                    underlyingItems.Add(new ProductInfo() { Code = newValue.ToString() });
                    multiDropDown.SelectedItem = underlyingItems.Last();
                }
            }
        }
    }



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
}
