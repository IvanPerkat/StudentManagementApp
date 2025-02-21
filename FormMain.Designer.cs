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
            pictureBoxMenu = new PictureBox();
            pictureBoxExit = new PictureBox();
            panel1 = new Panel();
            labelStudents = new Label();
            listBoxStudents = new ListBox();
            buttonAddStudent = new Button();
            buttonDelete = new Button();
            buttonDeleteAll = new Button();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(0, 138, 255);
            panelSideBar.Controls.Add(pictureBoxMenu);
            panelSideBar.Controls.Add(pictureBoxExit);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Margin = new Padding(2);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(91, 425);
            panelSideBar.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Anchor = AnchorStyles.None;
            pictureBoxMenu.Cursor = Cursors.Hand;
            pictureBoxMenu.Image = (Image)resources.GetObject("pictureBoxMenu.Image");
            pictureBoxMenu.Location = new Point(27, 12);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(35, 35);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenu.TabIndex = 1;
            pictureBoxMenu.TabStop = false;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.Anchor = AnchorStyles.None;
            pictureBoxExit.Cursor = Cursors.Hand;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(27, 385);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(30, 30);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExit.TabIndex = 0;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelStudents);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(91, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 50);
            panel1.TabIndex = 1;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudents.Location = new Point(11, 12);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(105, 24);
            labelStudents.TabIndex = 2;
            labelStudents.Text = "STUDENTI";
            // 
            // listBoxStudents
            // 
            listBoxStudents.BackColor = Color.FromArgb(248, 248, 248);
            listBoxStudents.ForeColor = Color.Black;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(115, 67);
            listBoxStudents.Margin = new Padding(5);
            listBoxStudents.MultiColumn = true;
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(703, 208);
            listBoxStudents.TabIndex = 0;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = Color.FromArgb(0, 138, 255);
            buttonAddStudent.FlatAppearance.BorderColor = Color.FromArgb(0, 138, 255);
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Location = new Point(115, 385);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(95, 28);
            buttonAddStudent.TabIndex = 2;
            buttonAddStudent.Text = "Dodaj";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(0, 138, 255);
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 138, 255);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(216, 385);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 28);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Izbriši";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.FromArgb(0, 138, 255);
            buttonDeleteAll.FlatAppearance.BorderColor = Color.FromArgb(0, 138, 255);
            buttonDeleteAll.FlatAppearance.BorderSize = 0;
            buttonDeleteAll.FlatStyle = FlatStyle.Flat;
            buttonDeleteAll.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteAll.ForeColor = Color.White;
            buttonDeleteAll.Location = new Point(317, 385);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(95, 28);
            buttonDeleteAll.TabIndex = 4;
            buttonDeleteAll.Text = "Izbriši sve";
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(818, 425);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddStudent);
            Controls.Add(listBoxStudents);
            Controls.Add(panel1);
            Controls.Add(panelSideBar);
            Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Managment App";
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Panel panel1;
        private PictureBox pictureBoxExit;
        private ListBox listBoxStudents;
        private Label labelStudents;
        private PictureBox pictureBoxMenu;
        private Button buttonAddStudent;
        private Button buttonDelete;
        private Button buttonDeleteAll;
    }
}
