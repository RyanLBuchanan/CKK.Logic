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

    //public enum ProductDescription
    //{
    //    Window_Gadget_1,
    //    Window_Gadget_2,
    //    Window_Gadget_3,
    //    Window_Gadget_4,
    //    Window_Gadget_5,
    //}

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

    //public partial class MainWindow : Window
    //{

    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //        dataGrid.ItemsSource = Employee.GetEmployees();
    //    }
    //}

    //public enum Party
    //{
    //    Indepentent,
    //    Federalist,
    //    DemocratRepublican,
    //}

    //public class Employee : INotifyPropertyChanged
    //{
    //    private string name;

    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            name = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private string title;

    //    public string Title
    //    {
    //        get { return title; }
    //        set
    //        {
    //            title = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private bool wasReElected;

    //    public bool WasReElected
    //    {
    //        get { return wasReElected; }
    //        set
    //        {
    //            wasReElected = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    private Party affiliation;

    //    public Party Affiliation
    //    {
    //        get { return affiliation; }
    //        set
    //        {
    //            affiliation = value;
    //            RaiseProperChanged();
    //        }
    //    }

    //    public static ObservableCollection<Employee> GetEmployees()
    //    {
    //        var employees = new ObservableCollection<Employee>();

    //        employees.Add(new Employee()
    //        {
    //            Name = "Ali",
    //            Title = "Minister",
    //            WasReElected = true,
    //            Affiliation = Party.Indepentent
    //        });

    //        employees.Add(new Employee()
    //        {
    //            Name = "Ahmed",
    //            Title = "CM",
    //            WasReElected = false,
    //            Affiliation = Party.Federalist
    //        });

    //        employees.Add(new Employee()
    //        {
    //            Name = "Amjad",
    //            Title = "PM",
    //            WasReElected = true,
    //            Affiliation = Party.DemocratRepublican
    //        });

    //        employees.Add(new Employee()
    //        {
    //            Name = "Waqas",
    //            Title = "Minister",
    //            WasReElected = false,
    //            Affiliation = Party.Indepentent
    //        });

    //        employees.Add(new Employee()
    //        {
    //            Name = "Bilal",
    //            Title = "Minister",
    //            WasReElected = true,
    //            Affiliation = Party.Federalist
    //        });

    //        employees.Add(new Employee()
    //        {
    //            Name = "Waqar",
    //            Title = "Minister",
    //            WasReElected = false,
    //            Affiliation = Party.DemocratRepublican
    //        });

    //        return employees;
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void RaiseProperChanged([CallerMemberName] string caller = "")
    //    {

    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(caller));
    //        }
    //    }

    //}

}
