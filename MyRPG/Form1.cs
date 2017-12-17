using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace MyRPG
{
    public partial class Game : Form
    {
        private Player _player;

        public Game()
        {
            InitializeComponent();

            _player = new Player(100,100,10,0,1);

            lblHP.Text = _player.CurHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.ExperiencePts.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
