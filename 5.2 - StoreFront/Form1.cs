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
    public partial class frmLogin : Form
    {
        StoreServiceClient ssc;
        public frmLogin()
        {
            ssc = new StoreServiceClient();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String username = this.txtRegisterUsername.Text;
            Boolean unique = ssc.Register(username);
            if (unique)
            {
                lblGeneratedPassword2.ForeColor = Color.Black;
                lblGeneratedPassword2.Text = reverse(username);
            }
            else
            {
                lblGeneratedPassword2.ForeColor = Color.Red;
                lblGeneratedPassword2.Text = "User is not unique!";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = ssc.Login(this.txtUsername.Text, this.txtPassword.Text);

            if (u != null)
            {
                Form f = new frmStore(u, ssc);
                f.Show();
            }
        }
        public String reverse(String s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
