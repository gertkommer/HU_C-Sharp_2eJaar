using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1._6___TicTacToeEngine;

namespace _1._6___BoterKaasEieren
{
    public partial class Form1 : Form
    {
        private TicTacToeEngine t = new TicTacToeEngine();
        public Form1()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, EventArgs e)
        {
           

		    Button ingedrukt = (Button)sender;
            int n;
            if(int.TryParse(ingedrukt.Text,out n)){
                if (t.ChooseCell(n))
                {
                    if (t.Status.ToString() != "PlayerOPlays")
                    {
                        ingedrukt.Text = "O";
                    }
                    else
                    {
                        ingedrukt.Text = "X";
                    }
                    //if (t.Status == TicTacToeEngine.GameStatus.PlayerOWins)
                        if (t.Status.ToString().Substring(t.Status.ToString().Length - 4) == "Wins")
                        {
                            System.Windows.Forms.MessageBox.Show("End of game. " + t.Status.ToString());
                            t.ChooseCell(0);
                            Reset();
                        }
                        else if (t.Status.ToString() == "Equal")
                        {
                            System.Windows.Forms.MessageBox.Show("End of game. Draw");
                            t.ChooseCell(0);
                            Reset();
                        }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Dit is geen geldige move");
                }
                
		    }

        }

        private void Reset()
        {
            this.button1.Text = "1";
            this.button2.Text = "2";
            this.button3.Text = "3";
            this.button4.Text = "4";
            this.button5.Text = "5";
            this.button6.Text = "6";
            this.button7.Text = "7";
            this.button8.Text = "8";
            this.button9.Text = "9";
            
        }
    }
}
