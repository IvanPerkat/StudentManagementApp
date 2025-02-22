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
            ((System.ComponentModel.ISupportInitialize)trackBarYear).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(25, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(25, 76);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 23);
            textBoxSurname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 58);
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
            labelIndex.Location = new Point(25, 110);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(41, 15);
            labelIndex.TabIndex = 7;
            labelIndex.Text = "Indeks";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(25, 123);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(100, 23);
            textBoxIndex.TabIndex = 3;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(391, 22);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(86, 15);
            labelBirthDate.TabIndex = 9;
            labelBirthDate.Text = "Datum rođenja";
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new Point(187, 27);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new Size(121, 23);
            comboBoxCourse.TabIndex = 10;
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(187, 9);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(37, 15);
            labelCourse.TabIndex = 11;
            labelCourse.Text = "Smjer";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(391, 40);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(200, 23);
            dateTimePickerBirthDay.TabIndex = 12;
            // 
            // trackBarYear
            // 
            trackBarYear.Location = new Point(187, 110);
            trackBarYear.Name = "trackBarYear";
            trackBarYear.Size = new Size(100, 45);
            trackBarYear.TabIndex = 13;
            trackBarYear.Scroll += trackBarYear_Scroll;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(187, 83);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(45, 15);
            labelYear.TabIndex = 14;
            labelYear.Text = "Godina";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(293, 110);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(25, 23);
            textBoxYear.TabIndex = 15;
            textBoxYear.TextAlign = HorizontalAlignment.Right;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}