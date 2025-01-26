namespace Side_Scrolling_Game_Our_Project_
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.QUITbtn = new System.Windows.Forms.Button();
            this.PLAYbtn = new System.Windows.Forms.Button();
            this.yourNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Algerian", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side Scrolling ";
            // 
            // QUITbtn
            // 
            this.QUITbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.QUITbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QUITbtn.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUITbtn.Location = new System.Drawing.Point(220, 261);
            this.QUITbtn.Name = "QUITbtn";
            this.QUITbtn.Size = new System.Drawing.Size(143, 77);
            this.QUITbtn.TabIndex = 3;
            this.QUITbtn.Text = "QUIT";
            this.QUITbtn.UseVisualStyleBackColor = false;
            this.QUITbtn.Click += new System.EventHandler(this.QUITbtn_Click);
            // 
            // PLAYbtn
            // 
            this.PLAYbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PLAYbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PLAYbtn.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYbtn.Location = new System.Drawing.Point(97, 154);
            this.PLAYbtn.Name = "PLAYbtn";
            this.PLAYbtn.Size = new System.Drawing.Size(174, 84);
            this.PLAYbtn.TabIndex = 1;
            this.PLAYbtn.Text = "PLAY";
            this.PLAYbtn.UseVisualStyleBackColor = false;
            this.PLAYbtn.Click += new System.EventHandler(this.PLAYbtn_Click);
            // 
            // yourNameLbl
            // 
            this.yourNameLbl.AutoSize = true;
            this.yourNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yourNameLbl.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourNameLbl.Location = new System.Drawing.Point(55, 94);
            this.yourNameLbl.Name = "yourNameLbl";
            this.yourNameLbl.Size = new System.Drawing.Size(187, 21);
            this.yourNameLbl.TabIndex = 7;
            this.yourNameLbl.Text = "Enter Your Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Side_Scrolling_Game_Our_Project_.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 367);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.yourNameLbl);
            this.Controls.Add(this.QUITbtn);
            this.Controls.Add(this.PLAYbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button QUITbtn;
        private System.Windows.Forms.Button PLAYbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label yourNameLbl;
    }
}