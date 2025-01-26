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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string playerName)
        {
            InitializeComponent();
            yourNameLbl.Text = " HELLO " + playerName;
            
        }

        private void PLAYbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();            
        }

        private void QUITbtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are You Sure", "QUIT GAME" , MessageBoxButtons.OKCancel , MessageBoxIcon.Information );
            if ( result == DialogResult.OK )
            {
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
