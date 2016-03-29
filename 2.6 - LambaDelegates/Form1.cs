using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practicum2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            num1Text.Text = r.Next(1, 10) + "";
            num2Text.Text = r.Next(1, 10) + "";
            num3Text.Text = r.Next(1, 10) + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(num1Text.Text);
            int num2 = Int32.Parse(num2Text.Text);
            int num3 = Int32.Parse(num3Text.Text);
            
            String output = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = output;
            String[] methodLines = output.Split('\n');

            output = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = output;
            String[] lambaLines = output.Split('\n');

            bool same = true;
            if (lambaLines.Length != methodLines.Length) { same = false; }
            if (same)
            {
                for (int i = 0; i < lambaLines.Length; i++)
                {
                    String methodResult = methodLines[i].Substring(methodLines[i].LastIndexOf('=') + 1);
                    String lambaResult = methodLines[i].Substring(methodLines[i].LastIndexOf('=') + 1);
                    if (methodResult != lambaResult)
                    {
                        same = false;
                    }
                }
            }
            if (same)
            {
                MessageBox.Show("Result OK");
            }
            else
            {
                MessageBox.Show("Result Not OK");
            }
             
        }
    }
}
