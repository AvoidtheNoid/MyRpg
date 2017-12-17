using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRPG
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            lblHP.Text = "100";
            lblGold.Text = "10";
            lblExp.Text = "0";
            lblLevel.Text = "1";
        }
    }
}
