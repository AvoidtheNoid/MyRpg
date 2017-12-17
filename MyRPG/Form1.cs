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

            _player = new Player();

            _player.CurHitPoints = 100;
            _player.MaxHitPoints = 999;
            _player.Gold = 10;
            _player.ExperiencePts = 0;
            _player.Level = 1;

            lblHP.Text = _player.CurHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.ExperiencePts.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
