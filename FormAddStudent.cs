using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace StudentManagementApp
{
    public partial class FormAddStudent : Form
    {
        private string text = "";
        private string caption = "";
        private MessageBoxButtons buttons;
        private MessageBoxIcon icon;
        private List<string> emptyFields = new();
        private DateTime currentTime = DateTime.Now;
        private Dictionary<string, string> translatedNames = new()
        {
            { "Name", "Ime" },
            { "Surname", "Prezime" },
            { "Index", "Indeks" },
            { "Course", "Smjer" },
            { "Year", "Godina" }
        };

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Student? Student { get; set; }

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += timer1_Tick;

            comboBoxCourse.Items.Add("Računarstvo");
            comboBoxCourse.Items.Add("Elektronika");
            comboBoxCourse.Items.Add("Mehatronika");
            comboBoxCourse.Items.Add("Robotika");
            comboBoxCourse.Items.Add("Brodogradnja");

            trackBarYear.Minimum = 1;
            trackBarYear.Maximum = 5;
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            toolStripStatusLabelCurrentTime.Text = $"Trenutro vrijeme: {DateTime.Now.ToLongTimeString()}";

            TimeSpan expiredTime = DateTime.Now - currentTime;

            toolStripStatusLabelExpiredTime.Text = $"Proteklo vrijeme: {expiredTime.Hours.ToString("D2")}:{expiredTime.Minutes.ToString("D2")}:{expiredTime.Seconds.ToString("D2")}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {
                        string empty = textBox.Name.Replace("textBox", "");
                        emptyFields.Add(translatedNames.TryGetValue(empty, out string? translated) ? translated : empty);
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (String.IsNullOrEmpty(comboBox.Text))
                    {
                        string empty = comboBox.Name.Replace("comboBox", "");
                        emptyFields.Add(translatedNames.TryGetValue(empty, out string? translated) ? translated : empty);
                    }
                }
                else if (control is TrackBar trackBar)
                {
                    if (String.IsNullOrEmpty(trackBar.Value.ToString()))
                    {
                        string empty = trackBar.Name.Replace("trackBar", "");
                        emptyFields.Add(translatedNames.TryGetValue(empty, out string? translated) ? translated : empty);
                    }
                }
            }

            if (emptyFields.Count > 0)
            {
                text = $"Polja: {String.Join(", ", emptyFields)} su prazna!";
                caption = "Pogrešan unos";
                buttons = MessageBoxButtons.OK;
                icon = MessageBoxIcon.Warning;

                MessageBox.Show(text, caption, buttons, icon);

                emptyFields.Clear();
            }
            else
            {
                Student = new Student(
                    textBoxName.Text,
                    textBoxSurname.Text,
                    textBoxIndex.Text,
                    comboBoxCourse.Text,
                    DateOnly.FromDateTime(dateTimePickerBirthDay.Value),
                    trackBarYear.Value
                    );

                DialogResult = DialogResult.Yes;

                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            text = "Želite li izaći iz unosa studenta?";
            caption = "Izlaite iz unosa studenta";
            buttons = MessageBoxButtons.YesNo;
            icon = MessageBoxIcon.Warning;

            MessageBox.Show(text, caption, buttons, icon);

            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void trackBarYear_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBarYear.Value.ToString();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Izaberite sliku";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
