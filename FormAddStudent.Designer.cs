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
            label1 = new Label();
            label2 = new Label();
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
            textBoxYear = new TextBox();
            pictureBoxStudentImage = new PictureBox();
            labelStudentImage = new Label();
            buttonLoadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(25, 163);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(25, 217);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 23);
            textBoxSurname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 150);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 199);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Prezime";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(25, 315);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(167, 315);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Otkaži";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(25, 251);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(41, 15);
            labelIndex.TabIndex = 7;
            labelIndex.Text = "Indeks";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(25, 264);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(100, 23);
            textBoxIndex.TabIndex = 3;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(391, 163);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(86, 15);
            labelBirthDate.TabIndex = 9;
            labelBirthDate.Text = "Datum rođenja";
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new Point(187, 168);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(121, 23);
            comboBoxCourse.TabIndex = 10;
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(187, 150);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(37, 15);
            labelCourse.TabIndex = 11;
            labelCourse.Text = "Smjer";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(391, 181);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(200, 23);
            dateTimePickerBirthDay.TabIndex = 12;
            // 
            // trackBarYear
            // 
            trackBarYear.Location = new Point(187, 251);
            trackBarYear.Name = "trackBarYear";
            trackBarYear.Size = new Size(100, 45);
            trackBarYear.TabIndex = 13;
            trackBarYear.Scroll += trackBarYear_Scroll;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(187, 224);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(45, 15);
            labelYear.TabIndex = 14;
            labelYear.Text = "Godina";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(293, 251);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(25, 23);
            textBoxYear.TabIndex = 15;
            textBoxYear.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.Image = (Image)resources.GetObject("pictureBoxStudentImage.Image");
            pictureBoxStudentImage.Location = new Point(504, 29);
            pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            pictureBoxStudentImage.Size = new Size(87, 85);
            pictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudentImage.TabIndex = 16;
            pictureBoxStudentImage.TabStop = false;
            // 
            // labelStudentImage
            // 
            labelStudentImage.AutoSize = true;
            labelStudentImage.Location = new Point(397, 26);
            labelStudentImage.Name = "labelStudentImage";
            labelStudentImage.Size = new Size(31, 15);
            labelStudentImage.TabIndex = 17;
            labelStudentImage.Text = "Slika";
            // 
            // buttonLoadImage
            // 
            buttonLoadImage.Location = new Point(397, 91);
            buttonLoadImage.Name = "buttonLoadImage";
            buttonLoadImage.Size = new Size(93, 23);
            buttonLoadImage.TabIndex = 18;
            buttonLoadImage.Text = "Izaberi sliku";
            buttonLoadImage.UseVisualStyleBackColor = true;
            buttonLoadImage.Click += buttonLoadImage_Click;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadImage);
            Controls.Add(labelStudentImage);
            Controls.Add(pictureBoxStudentImage);
            Controls.Add(textBoxYear);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "FormAddStudent";
            Text = "FormAddStudent";
            Load += FormAddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label1;
        private Label label2;
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
        private TextBox textBoxYear;
        private PictureBox pictureBoxStudentImage;
        private Label labelStudentImage;
        private Button buttonLoadImage;
    }
}