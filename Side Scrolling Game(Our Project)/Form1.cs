using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Side_Scrolling_Game_Our_Project_
{
    public partial class Form1 : Form
    {
          

        bool goLeft; // control player going left
        bool goRight; // control player going right
        bool jumping; // control player is jumping or not
        bool hasKey; // defalt value of whether the player has the key
                

        int jumpSpeed = 10; // integer to set jump speed 
        int force = 8; // force of the jump in an integer 
        int score = 0; // defalt score integer set to 0
        int playerSpeed = 10; // set player speed  
        int backgroundSpeed = 10; // background moving speed 

        public Form1()
        {
            InitializeComponent();
        }

        

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtscore.Text = "Score : " + score;

            player.Top += jumpSpeed; // linking the jumpspeed integer with the player picture boxes to location

            // if go left is true and players left is greater than 60 pixels
            // only then move player towards left of the 
            if (goLeft == true && player.Left > 60)
            {
                player.Left -= playerSpeed;
            }
            // by doing the if statement above, the player picture will stop on the forms left


            // player left plus players width plus 60 is less than the forms width
            // then we move the player towards the right by adding to the players left
            if (goRight == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            } 
            // by doing the if statement above, the player picture will stop on the forms right
 
            
            // if go right is true and the background picture left is greater 1377
            // then we move the background picture towards the left
            if (goLeft == true && background.Left < 0)
            {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }
            if (goRight == true && background.Left > -1377)
            {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if(jumping == true)
            {
                jumpSpeed = -12;// if jumping is true , then change jump speed to -12
                force -= 1; // reduce force by 1
            }
            else
            {
                jumpSpeed = 12; // else change the jump speed to 12
            }

            // if jumping is true and force is less than 0
            // then change jumping to false
            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            // below if the for loop thats checking for all of the controls in this form
            foreach (Control x in this.Controls)
            {
                // is X is a picture box and it has a tag of platform
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    // then we are checking if the player is colliding with the platform
                    // and jumping is set to false
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    { 
                        // then we do the following
                        force = 8; // set the force to 8
                        player.Top = x.Top - player.Height; // also we place the player on top of the picture box
                        jumpSpeed = 0; // set the jump speed to 0
                    }
                    x.BringToFront();
                }

                // if the picture box found has a tag of coin
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    // now if the player collides with the coin picture box
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false; // then we are going to remove the coin image
                        score += 2; //game score(one coin = 2 score)
                    }
                }
            }

            // if the picture box found has a key
            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                key.Visible = false; // then we are going to remove the coin image
                hasKey = true;
            }


            if(player.Bounds.IntersectsWith(door.Bounds) && hasKey == true)
            {
                // then we change the image of the door to open
                door.Image = Properties.Resources.door_open;
                GameTimer.Stop(); // and we stop the timer
                // show the messagebox
                DialogResult result;
                result = MessageBox.Show("Well Done, your journery is complete! " + Environment.NewLine + "Click YES to go next level" , "YOU WIN" , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    this.Hide();
                    commingSoon CommingSoon = new commingSoon();
                    CommingSoon.Show();
                }
                else if(result == DialogResult.No)
                {
                    this.Close();
                }
            }

            // this is where the player dies
            // if the player goes below the forms height then we will end the game
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                GameTimer.Stop(); // stop the timer
                // show the message box
                DialogResult result;
                result = MessageBox.Show("You Died!" + Environment.NewLine + "Click YES to play again" , "DIED" , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
                else if(result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void KeysDown(object sender, KeyEventArgs e)
        {
            // player pruss the left key AND the player is inside the pannel
            
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true; // then we set the player left boolean to true
            }

            // if player pressed the right key and the player left plus player width is less then the panel1 width 

            if (e.KeyCode == Keys.Right)
            {
                goRight = true; // then we set the player right to true
            }

            //if the player pressed the space key and jumping boolean is false

            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true; // then we set jumping to true
            }
        }

        private void KeysUp(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            // if the RIGHT key is up we set the car right to false

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            //when the keys are released we check if jumping is true
            // if so we need to set it back to false so the player can jump again

            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        } 

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtscore_Click(object sender, EventArgs e)
        {

        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame() // method restart game 
        {
            Form1 newWindow = new Form1(); // create object
            newWindow.Show(); // call new window
            this.Hide(); // this window hide 
        }

        private void MoveGameElements(string direction) // moving game elements
        {
             foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "coin" || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "door")
                {
                    if(direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if(direction == "forward")
                    {
                        x.Left += backgroundSpeed; 
                    }
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
