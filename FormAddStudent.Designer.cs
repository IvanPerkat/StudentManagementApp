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
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(23, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(196, 24);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(23, 147);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(196, 24);
            textBoxSurname.TabIndex = 1;
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
            labelSurname.Location = new Point(23, 127);
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
            buttonAdd.Location = new Point(23, 339);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 28);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(0, 138, 255);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(124, 339);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(95, 28);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Otkaži";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(23, 266);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(48, 17);
            labelIndex.TabIndex = 7;
            labelIndex.Text = "Indeks";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(23, 286);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(196, 24);
            textBoxIndex.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(23, 198);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(99, 17);
            labelBirthDate.TabIndex = 9;
            labelBirthDate.Text = "Datum rođenja";
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new Point(265, 218);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(149, 25);
            comboBoxCourse.TabIndex = 5;
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(265, 198);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(42, 17);
            labelCourse.TabIndex = 11;
            labelCourse.Text = "Smjer";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(23, 218);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(196, 24);
            dateTimePickerBirthDay.TabIndex = 3;
            // 
            // trackBarYear
            // 
            trackBarYear.Location = new Point(265, 286);
            trackBarYear.Name = "trackBarYear";
            trackBarYear.Size = new Size(114, 45);
            trackBarYear.TabIndex = 6;
            trackBarYear.Scroll += trackBarYear_Scroll;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(265, 266);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(52, 17);
            labelYear.TabIndex = 14;
            labelYear.Text = "Godina";
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxStudentImage.Image = (Image)resources.GetObject("pictureBoxStudentImage.Image");
            pictureBoxStudentImage.Location = new Point(386, 72);
            pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            pictureBoxStudentImage.Size = new Size(99, 99);
            pictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudentImage.TabIndex = 16;
            pictureBoxStudentImage.TabStop = false;
            // 
            // labelStudentImage
            // 
            labelStudentImage.AutoSize = true;
            labelStudentImage.Location = new Point(265, 71);
            labelStudentImage.Name = "labelStudentImage";
            labelStudentImage.Size = new Size(35, 17);
            labelStudentImage.TabIndex = 17;
            labelStudentImage.Text = "Slika";
            // 
            // buttonLoadImage
            // 
            buttonLoadImage.FlatStyle = FlatStyle.Flat;
            buttonLoadImage.ForeColor = Color.FromArgb(0, 138, 255);
            buttonLoadImage.Location = new Point(265, 144);
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
            panelTopBar.Size = new Size(516, 50);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 286);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 20;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(516, 378);
            Controls.Add(label3);
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
        private Label label3;
    }
}