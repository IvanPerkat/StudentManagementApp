namespace StudentManagementApp
{
    partial class FormAddStudent
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStudent));
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            labelName = new Label();
            labelSurname = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            labelIndex = new Label();
            textBoxIndex = new TextBox();
            labelBirthDate = new Label();
            comboBoxCourse = new ComboBox();
            labelCourse = new Label();
            dateTimePickerBirthDay = new DateTimePicker();
            trackBarYear = new TrackBar();
            labelYear = new Label();
            pictureBoxStudentImage = new PictureBox();
            labelStudentImage = new Label();
            buttonLoadImage = new Button();
            panelTopBar = new Panel();
            labelAddStudent = new Label();
            labelShowYear = new Label();
            statusStripTime = new StatusStrip();
            toolStripStatusLabelCurrentTime = new ToolStripStatusLabel();
            toolStripStatusLabelExpiredTime = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            groupBoxCourseType = new GroupBox();
            radioButtonNonRegular = new RadioButton();
            radioButtonRegular = new RadioButton();
            contextMenuStrip = new ContextMenuStrip(components);
            copyToSurnameToolStripMenuItem = new ToolStripMenuItem();
            copyToIndexToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)trackBarYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            panelTopBar.SuspendLayout();
            statusStripTime.SuspendLayout();
            groupBoxCourseType.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.ContextMenuStrip = contextMenuStrip;
            textBoxName.Location = new Point(23, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(196, 24);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.ContextMenuStrip = contextMenuStrip;
            textBoxSurname.Location = new Point(23, 145);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(196, 24);
            textBoxSurname.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(23, 65);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 17);
            labelName.TabIndex = 2;
            labelName.Text = "Ime";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(23, 125);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(56, 17);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Prezime";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(0, 138, 255);
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(23, 371);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 28);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(0, 138, 255);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(124, 371);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(95, 28);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Otkaži";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(23, 185);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(48, 17);
            labelIndex.TabIndex = 7;
            labelIndex.Text = "Indeks";
            // 
            // textBoxIndex
            // 
            textBoxIndex.ContextMenuStrip = contextMenuStrip;
            textBoxIndex.Location = new Point(23, 205);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(196, 24);
            textBoxIndex.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(23, 245);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(99, 17);
            labelBirthDate.TabIndex = 9;
            labelBirthDate.Text = "Datum rođenja";
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new Point(23, 325);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(196, 25);
            comboBoxCourse.TabIndex = 5;
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(23, 305);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(42, 17);
            labelCourse.TabIndex = 11;
            labelCourse.Text = "Smjer";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(23, 265);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(196, 24);
            dateTimePickerBirthDay.TabIndex = 3;
            // 
            // trackBarYear
            // 
            trackBarYear.Location = new Point(263, 205);
            trackBarYear.Name = "trackBarYear";
            trackBarYear.Size = new Size(114, 45);
            trackBarYear.TabIndex = 6;
            trackBarYear.Scroll += trackBarYear_Scroll;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(263, 185);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(52, 17);
            labelYear.TabIndex = 14;
            labelYear.Text = "Godina";
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxStudentImage.Image = (Image)resources.GetObject("pictureBoxStudentImage.Image");
            pictureBoxStudentImage.Location = new Point(383, 65);
            pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            pictureBoxStudentImage.Size = new Size(99, 99);
            pictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudentImage.TabIndex = 16;
            pictureBoxStudentImage.TabStop = false;
            // 
            // labelStudentImage
            // 
            labelStudentImage.AutoSize = true;
            labelStudentImage.Location = new Point(262, 65);
            labelStudentImage.Name = "labelStudentImage";
            labelStudentImage.Size = new Size(35, 17);
            labelStudentImage.TabIndex = 17;
            labelStudentImage.Text = "Slika";
            // 
            // buttonLoadImage
            // 
            buttonLoadImage.FlatStyle = FlatStyle.Flat;
            buttonLoadImage.ForeColor = Color.FromArgb(0, 138, 255);
            buttonLoadImage.Location = new Point(262, 138);
            buttonLoadImage.Name = "buttonLoadImage";
            buttonLoadImage.Size = new Size(106, 26);
            buttonLoadImage.TabIndex = 18;
            buttonLoadImage.Text = "Izaberi sliku";
            buttonLoadImage.UseVisualStyleBackColor = true;
            buttonLoadImage.Click += buttonLoadImage_Click;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.White;
            panelTopBar.Controls.Add(labelAddStudent);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(503, 50);
            panelTopBar.TabIndex = 19;
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddStudent.Location = new Point(11, 12);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(186, 24);
            labelAddStudent.TabIndex = 3;
            labelAddStudent.Text = "DODAJ STUDENTA";
            // 
            // labelShowYear
            // 
            labelShowYear.AutoSize = true;
            labelShowYear.Location = new Point(383, 205);
            labelShowYear.Name = "labelShowYear";
            labelShowYear.Size = new Size(14, 17);
            labelShowYear.TabIndex = 20;
            labelShowYear.Text = "  ";
            // 
            // statusStripTime
            // 
            statusStripTime.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStripTime.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCurrentTime, toolStripStatusLabelExpiredTime });
            statusStripTime.Location = new Point(0, 416);
            statusStripTime.Name = "statusStripTime";
            statusStripTime.RenderMode = ToolStripRenderMode.Professional;
            statusStripTime.Size = new Size(503, 22);
            statusStripTime.SizingGrip = false;
            statusStripTime.TabIndex = 21;
            // 
            // toolStripStatusLabelCurrentTime
            // 
            toolStripStatusLabelCurrentTime.Name = "toolStripStatusLabelCurrentTime";
            toolStripStatusLabelCurrentTime.Size = new Size(0, 17);
            // 
            // toolStripStatusLabelExpiredTime
            // 
            toolStripStatusLabelExpiredTime.Name = "toolStripStatusLabelExpiredTime";
            toolStripStatusLabelExpiredTime.Size = new Size(0, 17);
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // groupBoxCourseType
            // 
            groupBoxCourseType.Controls.Add(radioButtonNonRegular);
            groupBoxCourseType.Controls.Add(radioButtonRegular);
            groupBoxCourseType.FlatStyle = FlatStyle.Flat;
            groupBoxCourseType.Location = new Point(260, 245);
            groupBoxCourseType.Name = "groupBoxCourseType";
            groupBoxCourseType.Size = new Size(116, 82);
            groupBoxCourseType.TabIndex = 22;
            groupBoxCourseType.TabStop = false;
            groupBoxCourseType.Text = "Vrsta studija";
            // 
            // radioButtonNonRegular
            // 
            radioButtonNonRegular.AutoSize = true;
            radioButtonNonRegular.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 138, 255);
            radioButtonNonRegular.Location = new Point(6, 51);
            radioButtonNonRegular.Name = "radioButtonNonRegular";
            radioButtonNonRegular.Size = new Size(93, 21);
            radioButtonNonRegular.TabIndex = 1;
            radioButtonNonRegular.TabStop = true;
            radioButtonNonRegular.Text = "Izvanredan";
            radioButtonNonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonRegular
            // 
            radioButtonRegular.AutoSize = true;
            radioButtonRegular.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 138, 255);
            radioButtonRegular.Location = new Point(6, 24);
            radioButtonRegular.Name = "radioButtonRegular";
            radioButtonRegular.Size = new Size(87, 21);
            radioButtonRegular.TabIndex = 0;
            radioButtonRegular.TabStop = true;
            radioButtonRegular.Text = "Regularan";
            radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { copyToSurnameToolStripMenuItem, copyToIndexToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(181, 70);
            // 
            // copyToSurnameToolStripMenuItem
            // 
            copyToSurnameToolStripMenuItem.Name = "copyToSurnameToolStripMenuItem";
            copyToSurnameToolStripMenuItem.Size = new Size(180, 22);
            copyToSurnameToolStripMenuItem.Text = "Kopiraj u Prezime";
            copyToSurnameToolStripMenuItem.Click += copyToSurnameToolStripMenuItem_Click;
            // 
            // copyToIndexToolStripMenuItem
            // 
            copyToIndexToolStripMenuItem.Name = "copyToIndexToolStripMenuItem";
            copyToIndexToolStripMenuItem.Size = new Size(180, 22);
            copyToIndexToolStripMenuItem.Text = "Kopiraj u Indeks";
            copyToIndexToolStripMenuItem.Click += copyToIndexToolStripMenuItem_Click;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(503, 438);
            Controls.Add(groupBoxCourseType);
            Controls.Add(statusStripTime);
            Controls.Add(labelShowYear);
            Controls.Add(panelTopBar);
            Controls.Add(buttonLoadImage);
            Controls.Add(labelStudentImage);
            Controls.Add(pictureBoxStudentImage);
            Controls.Add(labelYear);
            Controls.Add(trackBarYear);
            Controls.Add(dateTimePickerBirthDay);
            Controls.Add(labelCourse);
            Controls.Add(comboBoxCourse);
            Controls.Add(labelBirthDate);
            Controls.Add(labelIndex);
            Controls.Add(textBoxIndex);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAddStudent";
            Text = "Dodaj studenta";
            Load += FormAddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).EndInit();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            statusStripTime.ResumeLayout(false);
            statusStripTime.PerformLayout();
            groupBoxCourseType.ResumeLayout(false);
            groupBoxCourseType.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label labelName;
        private Label labelSurname;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label labelIndex;
        private TextBox textBoxIndex;
        private Label labelBirthDate;
        private ComboBox comboBoxCourse;
        private Label labelCourse;
        private DateTimePicker dateTimePickerBirthDay;
        private TrackBar trackBarYear;
        private Label labelYear;
        private PictureBox pictureBoxStudentImage;
        private Label labelStudentImage;
        private Button buttonLoadImage;
        private Panel panelTopBar;
        private Label labelAddStudent;
        private Label labelShowYear;
        private StatusStrip statusStripTime;
        private ToolStripStatusLabel toolStripStatusLabelCurrentTime;
        private ToolStripStatusLabel toolStripStatusLabelExpiredTime;
        private System.Windows.Forms.Timer timer;
        private GroupBox groupBoxCourseType;
        private RadioButton radioButtonNonRegular;
        private RadioButton radioButtonRegular;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem copyToSurnameToolStripMenuItem;
        private ToolStripMenuItem copyToIndexToolStripMenuItem;
    }
}