using Microsoft.Win32;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BookLibraryDemoWithWPFDataGrid
{
    public class MainWindowBehavior : Behavior<MainWindow>
    {
        string filterText = "All";

       
        protected override void OnAttached()
        {           
            base.OnAttached();
            this.AssociatedObject.dataGrid.SearchHelper.SearchBrush = Brushes.Green;
            this.AssociatedObject.navigationDrawer.ItemClicked += NavigationDrawer_ItemClicked;
            this.AssociatedObject.navigationDrawer.Closing += NavigationDrawer_Closing;
          //  this.AssociatedObject.searchButton.Click += SearchButton_Click;
            this.AssociatedObject.exportToExcelButton.Click += ExportToExcelButton_Click;
            this.AssociatedObject.exportToPDFButton.Click += ExportToPDFButton_Click;
            this.AssociatedObject.SearchBox.TextChanged += SearchBox_TextChanged;
            this.AssociatedObject.editButton.Click += EditButton_Click;
            this.AssociatedObject.deleteButton.Click += DeleteButton_Click;
            this.AssociatedObject.allowCaseSensitiveCheckBox.Click += AllowCaseSensitiveCheckBox_Checked;
            this.AssociatedObject.allowFilteringCheckBox.Click += AllowFilteringCheckBox_Checked;
        }

        private void AllowFilteringCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.AssociatedObject.dataGrid.SearchHelper.AllowFiltering = (bool)(e.OriginalSource as CheckBox).IsChecked;
        }

        private void AllowCaseSensitiveCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.AssociatedObject.dataGrid.SearchHelper.AllowCaseSensitiveSearch = (bool)(e.OriginalSource as CheckBox).IsChecked;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            (this.AssociatedObject.dataGrid.DataContext as LibraryViewModel).Books.Remove(this.AssociatedObject.dataGrid.CurrentItem as Book);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            this.AssociatedObject.dataGrid.SelectionController.CurrentCellManager.BeginEdit();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.AssociatedObject.dataGrid.SearchHelper.Search(this.AssociatedObject.SearchBox.Text);
        }

        private void NavigationDrawer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void ExportToPDFButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var document = this.AssociatedObject.dataGrid.ExportToPdf();
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf"
            };

            if (sfd.ShowDialog() == true)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    document.Save(stream);
                }

                //Message box confirmation to view the created Pdf file.

                if (MessageBox.Show("Do you want to view the Pdf file?", "Pdf file has been created",
                                    MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {

                    //Launching the Pdf file using the default Application.
                    System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(sfd.FileName);
                    info.UseShellExecute = true;
                    System.Diagnostics.Process.Start(info);
                }
            }
        }

        private void ExportToExcelButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            var excelEngine = this.AssociatedObject.dataGrid.ExportToExcel(this.AssociatedObject.dataGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (sfd.ShowDialog() == true)
            {
                using (Stream stream = sfd.OpenFile())
                {

                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;

                    else if (sfd.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;

                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created workbook.

                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                                    MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(sfd.FileName);
                    info.UseShellExecute = true;
                    System.Diagnostics.Process.Start(info);
                    
                }
            }
        }

        private void SearchButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.AssociatedObject.dataGrid.SearchHelper.Search(this.AssociatedObject.SearchBox.Text);
        }

        private void NavigationDrawer_ItemClicked(object? sender, Syncfusion.UI.Xaml.NavigationDrawer.NavigationItemClickedEventArgs e)
        {
            filterText = e.Item.Header.ToString();
           
            this.AssociatedObject.dataGrid.View.Filter = FilterRecords;
            this.AssociatedObject.dataGrid.View.RefreshFilter();
        }

        public bool FilterRecords(object o)
        {
            if (filterText == "All")
                return true;
            var item = o as Book;

            if (item != null)
            {

                if (item.Genre.Equals(filterText))
                    return true;
            }
            return false;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
        }
    }
}
