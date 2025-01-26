using System;
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
    public partial class playername : Form
    {
        public playername()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PLAYbtn_Click(object sender, EventArgs e)
        {
            if(NameTXT.Text != string.Empty)
            {
                string playerName = NameTXT.Text;
                MainForm mainForm = new MainForm(playerName);
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your Name and Age", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
