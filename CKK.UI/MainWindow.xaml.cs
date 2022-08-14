using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// CODE FROM MICROSOFT WPF TUTORIAL
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace CKK.UI
{
    public partial class MainWindow : Window
    {
        private IStore _Store;

        public ObservableCollection<StoreItem> _Items { get; private set; }

        public MainWindow(Store store)
        {
            _Store = store;
            InitializeComponent();        
            _Items = new ObservableCollection<StoreItem>();
            lbInventoryList.ItemsSource = _Items;
            RefreshList();
        }

        private void RefreshList()
        {
            _Items.Clear();
            foreach (StoreItem si in new ObservableCollection<StoreItem>(_Store.GetStoreItems()))_Items.Add(si);
        }

        Store tp = (Store)Application.Current.FindResource("globStore");
        //MainWindow inven = new MainWindow(tp);
        //inven.Show();
        //this.Close();
    }




         //<!--<DataGrid x:Name="productsDataGrid" Margin="10" Grid.Column="3" 
         //                 EnableRowVirtualization="True" 
         //                 Grid.Row="6" AlternatingRowBackground="LightGray"
         //                 AlternationCount="2" AutoGenerateColumns="False"
         //                 d:ItemsSource="{d:SampleData ItemCount=5}"
         //                 Grid.ColumnSpan="4">
         //           <DataGrid.Columns>
         //               <DataGridCheckBoxColumn Header = "__" Binding="{Binding __}" />
         //               <DataGridTextColumn Header = "ID" Binding="{Binding ID}" />
         //               <DataGridTextColumn Header = "Name" Binding="{Binding Name}" />
         //               <DataGridTextColumn Header = "Description" Binding="{Binding Description}" />
         //               <DataGridTextColumn Header = "Price" Binding="{Binding Price}" />
         //               <DataGridTextColumn Header = "Quantity" Binding="{Binding Quantity}" />
         //           </DataGrid.Columns>
         //       </DataGrid>-->
    //public class GridProduct : INotifyPropertyChanged
    //{
    //    private bool gridProductChecked;

    //    public bool GridProductChecked
    //    {
    //        get { return gridProductChecked; }
    //        set
    //        {
    //            gridProductChecked = value;
    //            RaiseProperChanged();
    //        }
    //    }
    //    private int gridProductId;

    //    public int GridProductId
    //    {
    //        get { return gridProductId; }
    //        set
    //        {
    //            gridProductId = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private string gridProductName;

    //    public string GridProductName
    //    {
    //        get { return gridProductName; }
    //        set
    //        {
    //            gridProductName = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private string gridProductDescription;

    //    public string GridProductDescription
    //    {
    //        get { return gridProductDescription; }
    //        set
    //        {
    //            gridProductDescription = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private double gridProductPrice;

    //    public double GridProductPrice
    //    {
    //        get { return gridProductPrice; }
    //        set
    //        {
    //            gridProductPrice = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private int gridProductQuantity;

    //    public int GridProductQuantity
    //    {
    //        get { return gridProductQuantity; }
    //        set
    //        {
    //            gridProductQuantity = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    public static ObservableCollection<GridProduct> GetGridProducts()
    //    {
    //        //int newIDCounter = 0;

    //        var gridProducts = new ObservableCollection<GridProduct>();

    //        gridProducts.Add(new GridProduct()
    //        {
    //            GridProductChecked = false,
    //            GridProductId = 1,
    //            GridProductName = "Widget 1",
    //            GridProductDescription = "Windows Gadget 1",
    //            GridProductPrice = 1.00,
    //            GridProductQuantity = 1
    //        });

    //        gridProducts.Add(new GridProduct()
    //        {
    //            GridProductChecked = false,
    //            GridProductId = 2,
    //            GridProductName = "Widget 2",
    //            GridProductDescription = "Windows Gadget 2",
    //            GridProductPrice = 2.00,
    //            GridProductQuantity = 2
    //        });

    //        gridProducts.Add(new GridProduct()
    //        {
    //            GridProductChecked = false,
    //            GridProductId = 3,
    //            GridProductName = "Widget 3",
    //            GridProductDescription = "Windows Gadget 3",
    //            GridProductPrice = 3.00,
    //            GridProductQuantity = 3
    //        });

    //        gridProducts.Add(new GridProduct()
    //        {
    //            GridProductChecked = false,
    //            GridProductId = 4,
    //            GridProductName = "Widget 4",
    //            GridProductDescription = "Windows Gadget 4",
    //            GridProductPrice = 4.00,
    //            GridProductQuantity = 4
    //        });

    //        gridProducts.Add(new GridProduct()
    //        {
    //            GridProductChecked = false,
    //            GridProductId = 5,
    //            GridProductName = "Widget 5",
    //            GridProductDescription = "Windows Gadget 5",
    //            GridProductPrice = 5.00,
    //            GridProductQuantity = 5
    //        });

    //        return gridProducts;
    //    }

    //    //public event DependencyPropertyChangedEventHandler DependencyPropertyChanged;  // DependencyPropertyChanged?
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void RaiseProperChanged([CallerMemberName] string caller = "")
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(caller)); // DependencyPropertyChanged?
    //        }
    //    }

    //    //protected override void OnClosing(CancelEventArgs e)
    //    //{
    //    //    // clean up database connections
    //    //    _context.Dispose();
    //    //    base.OnClosing(e);
    //    //}
    //}
}
