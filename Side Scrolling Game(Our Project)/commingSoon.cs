﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Side_Scrolling_Game_Our_Project_
{
    public partial class commingSoon : Form
    {
        public commingSoon()
        {
            InitializeComponent();
        }

        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
