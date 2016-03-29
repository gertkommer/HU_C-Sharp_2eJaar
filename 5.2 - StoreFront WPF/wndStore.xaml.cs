using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using _5._2___StoreFront_WPF.StoreServiceReference;
using System.Collections;
namespace _5._2___StoreFront_WPF
{
    /// <summary>
    /// Interaction logic for wndStore.xaml
    /// </summary>
    public partial class wndStore : Window
    {
        StoreServiceClient ssc;
        User LoggedInUser { get; set; }
        public wndStore(User u, StoreServiceClient ssc)
        {
            InitializeComponent();
            this.ssc = ssc;
            this.LoggedInUser = u;
            Refresh();
            
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            IList selected = lboxProducts.SelectedItems;
            Console.WriteLine("selected size: " + selected.Count);
            if (selected.Count != 0) { 
                foreach (Object selectedItem in selected)
                {
                    String item = selectedItem.ToString();
                    String[] iteminfo = item.Split(',');
                    Product p = ssc.getProductByName(iteminfo[0]);

                    lblError.Foreground = Brushes.Red;
                    if (p != null)
                    {
                        String result = ssc.AddProductToInventory(LoggedInUser, p);
                        if (result.Substring(0, 5).Equals("You'v"))
                        {
                            lblError.Foreground = Brushes.Green;
                            
                        }
                        lblError.Content = result;
                    }
                    else
                    {
                        lblError.Content = "Product not found.";
                    }

                }
                Refresh();
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            lboxProducts.Items.Clear();
            lboxInventory.Items.Clear();
            foreach (Product p in this.ssc.GetProducts())
            {
                if (p.stock >= 1)
                {
                    lboxProducts.Items.Add(p.name + ", " + p.stock);
                }
            }
            Dictionary<Product, int> products = this.ssc.getInventory(ssc.GetUserByName(LoggedInUser.username));
            foreach (KeyValuePair<Product, int> product in products)
            {
                lboxInventory.Items.Add((product.Key).name + ", " + product.Value);
            }

            double inputValue = Math.Round(ssc.GetUserByName(LoggedInUser.username).saldo, 2, MidpointRounding.AwayFromZero);
            lblMoneyLeft2.Content = inputValue;
        }
    }
}
