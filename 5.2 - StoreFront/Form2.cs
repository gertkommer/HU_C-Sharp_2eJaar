using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5._2___StoreFront.StoreServiceReference;

namespace _5._2___StoreFront
{
    public partial class frmStore : Form
    {
        StoreServiceClient ssc;
        List<Product> products;
        User LoggedInUser { get; set; }
        public frmStore(User u, StoreServiceClient client)
        {
            ssc = client;
            this.LoggedInUser = u;
            addTestProducts();
            InitializeComponent();
            products = ssc.GetProducts();
            foreach (Product p in products)
            {
                this.lboxProducts.Items.Add(p);
            }
            
        }

        private void lboxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTestProducts()
        {
            ssc.AddProduct("Appel", 0.28, 2);
            ssc.AddProduct("Peer", 0.45, 5);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
