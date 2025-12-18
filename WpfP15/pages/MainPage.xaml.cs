using Microsoft.IdentityModel.Abstractions;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

using WpfP15.Models;
using WpfP15.Service;

namespace WpfP15.pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public Prak15MenshContext db = DBService.Instance.Context;
        public ObservableCollection<Product> products { get; set; } = new();
        public MainPage(bool IsManager)
        {
            InitializeComponent();

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            products.Clear();
            foreach (var product in db.Products.ToList())
                products.Add(product);
        }
    }
}
