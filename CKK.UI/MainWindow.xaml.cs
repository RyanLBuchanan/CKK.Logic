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

namespace CKK.UI
{
    public partial class MainWindow : Window
    {
        private IStore Store;

        public MainWindow()
        {
            Store = new Store();
            InitializeComponent();
            //productsGrid.ItemSource = Products.GetGridProducts();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Progress saved{searchText.Text}");
        }
    }

    public class GridProduct : INotifyPropertyChanged
    {
        private bool gridProductChecked;

        public bool GridProductChecked
        {
            get { return gridProductChecked; }
            set
            {
                gridProductChecked = value;
                RaiseProperChanged();
            }
        }
        private int gridProductId;

        public int GridProductId
        {
            get { return gridProductId; }
            set
            {
                gridProductId = value;
                RaiseProperChanged();
            }
        }

        private string gridProductName;

        public string GridProductName
        {
            get { return gridProductName; }
            set
            {
                gridProductName = value;
                RaiseProperChanged();
            }
        }

        private string gridProductDescription;

        public string GridProductDescription
        {
            get { return gridProductDescription; }
            set
            {
                gridProductDescription = value;
                RaiseProperChanged();
            }
        }

        private double gridProductPrice;

        public double GridProductPrice
        {
            get { return gridProductPrice; }
            set
            {
                gridProductPrice = value;
                RaiseProperChanged();
            }
        }

        private int gridProductQuantity;

        public int GridProductQuantity
        {
            get { return gridProductQuantity; }
            set
            {
                gridProductQuantity = value;
                RaiseProperChanged();
            }
        }

        public static ObservableCollection<GridProduct> GetGridProducts()
        {
            //int newIDCounter = 0;

            var gridProducts = new ObservableCollection<GridProduct>();

            gridProducts.Add(new GridProduct()
            {
                GridProductChecked = false,
                GridProductId = 1,
                GridProductName = "Widget 1",
                GridProductDescription = "Windows Gadget 1",
                GridProductPrice = 1.00,
                GridProductQuantity = 1
            });

            gridProducts.Add(new GridProduct()
            {
                GridProductChecked = false,
                GridProductId = 2,
                GridProductName = "Widget 2",
                GridProductDescription = "Windows Gadget 2",
                GridProductPrice = 2.00,
                GridProductQuantity = 2
            });

            gridProducts.Add(new GridProduct()
            {
                GridProductChecked = false,
                GridProductId = 3,
                GridProductName = "Widget 3",
                GridProductDescription = "Windows Gadget 3",
                GridProductPrice = 3.00,
                GridProductQuantity = 3
            });

            gridProducts.Add(new GridProduct()
            {
                GridProductChecked = false,
                GridProductId = 4,
                GridProductName = "Widget 4",
                GridProductDescription = "Windows Gadget 4",
                GridProductPrice = 4.00,
                GridProductQuantity = 4
            });

            gridProducts.Add(new GridProduct()
            {
                GridProductChecked = false,
                GridProductId = 5,
                GridProductName = "Widget 5",
                GridProductDescription = "Windows Gadget 5",
                GridProductPrice = 5.00,
                GridProductQuantity = 5
            });

            return gridProducts;
        }

        //public event DependencyPropertyChangedEventHandler DependencyPropertyChanged;  // DependencyPropertyChanged?
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseProperChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller)); // DependencyPropertyChanged?
            }
        }
    }
}
