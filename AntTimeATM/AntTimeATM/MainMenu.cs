﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntTimeATM
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigating toMiniStatement.cs
            new MiniStatement().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate to Cash Withdrwal
            new CashWithDrawal().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Navigatet to PIN Chnage
            new PINChange().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Navigating to Setting
            new Form1().Show();
            this.Hide();
        }
    }
}
