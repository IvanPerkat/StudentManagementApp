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
            panelTopBar = new Panel();
            labelStudents = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            listBoxStudents = new ListBox();
            buttonAddStudent = new Button();
            buttonDelete = new Button();
            buttonDeleteAll = new Button();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            panelTopBar.SuspendLayout();
            menuStrip.SuspendLayout();
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
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.White;
            panelTopBar.Controls.Add(labelStudents);
            panelTopBar.Controls.Add(menuStrip);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(91, 0);
            panelTopBar.Margin = new Padding(2);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(727, 70);
            panelTopBar.TabIndex = 1;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudents.Location = new Point(14, 36);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(105, 24);
            labelStudents.TabIndex = 2;
            labelStudents.Text = "STUDENTI";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(0, 138, 255);
            menuStrip.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(727, 24);
            menuStrip.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(74, 20);
            fileToolStripMenuItem.Text = "Datoteka";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = SystemColors.Control;
            openToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openToolStripMenuItem.ForeColor = Color.FromArgb(0, 138, 255);
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Otvori";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = SystemColors.Control;
            saveToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveToolStripMenuItem.ForeColor = Color.FromArgb(0, 138, 255);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Spremi";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, fontToolStripMenuItem });
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(74, 20);
            settingsToolStripMenuItem.Text = "Postavke";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.BackColor = SystemColors.Control;
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
            themeToolStripMenuItem.ForeColor = Color.FromArgb(0, 138, 255);
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(180, 22);
            themeToolStripMenuItem.Text = "Tema";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.ForeColor = Color.FromArgb(0, 138, 255);
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(180, 22);
            lightToolStripMenuItem.Text = "Svijetla";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.ForeColor = Color.FromArgb(0, 138, 255);
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(180, 22);
            darkToolStripMenuItem.Text = "Tamna";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.BackColor = SystemColors.Control;
            fontToolStripMenuItem.ForeColor = Color.FromArgb(0, 138, 255);
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Font";
            // 
            // listBoxStudents
            // 
            listBoxStudents.BackColor = Color.FromArgb(248, 248, 248);
            listBoxStudents.ForeColor = Color.Black;
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(115, 102);
            listBoxStudents.Margin = new Padding(5);
            listBoxStudents.MultiColumn = true;
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(703, 225);
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
            Controls.Add(panelTopBar);
            Controls.Add(panelSideBar);
            Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Managment App";
            Load += FormMain_Load;
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Panel panelTopBar;
        private PictureBox pictureBoxExit;
        private ListBox listBoxStudents;
        private Label labelStudents;
        private PictureBox pictureBoxMenu;
        private Button buttonAddStudent;
        private Button buttonDelete;
        private Button buttonDeleteAll;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
    }
}
