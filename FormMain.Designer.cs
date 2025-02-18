namespace StudentManagementApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelSideBar = new Panel();
            pictureBoxExit = new PictureBox();
            panel1 = new Panel();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(0, 138, 255);
            panelSideBar.Controls.Add(pictureBoxExit);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Margin = new Padding(2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(80, 461);
            panelSideBar.TabIndex = 0;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.Anchor = AnchorStyles.None;
            pictureBoxExit.Cursor = Cursors.Hand;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(24, 419);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(30, 30);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExit.TabIndex = 0;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 138, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(80, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 49);
            panel1.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(panel1);
            Controls.Add(panelSideBar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Managment App";
            Load += FormMain_Load;
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Panel panel1;
        private PictureBox pictureBoxExit;
    }
}
