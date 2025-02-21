using System.ComponentModel;
using System.Drawing.Text;

namespace StudentManagementApp
{
    public partial class FormAddStudent : Form
    {
        private string text = "";
        private string caption = "";
        private MessageBoxButtons buttons;
        private MessageBoxIcon icon;
        List<string> emptyFields = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Student? Student { get; set; }

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            comboBoxCourse.Items.Add("Računarstvo");
            comboBoxCourse.Items.Add("Elektronika");
            comboBoxCourse.Items.Add("Mehatronika");
            comboBoxCourse.Items.Add("Robotika");
            comboBoxCourse.Items.Add("Brodogradnja");
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
                        emptyFields.Add(TranslatedNames(empty));
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (String.IsNullOrEmpty(comboBox.Text))
                    {
                        string empty = comboBox.Name.Replace("comboBox", "");
                        emptyFields.Add(TranslatedNames(empty));
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
            }
            else
            {
                Student = new Student(
                    textBoxName.Text,
                    textBoxSurname.Text,
                    textBoxIndex.Text,
                    comboBoxCourse.Text,
                    DateOnly.FromDateTime(dateTimePickerBirthDay.Value)
                    );

                DialogResult = DialogResult.Yes;

                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private string TranslatedNames(string name) => name switch
        {
            "Name" => "Ime",
            "Surname" => "Prezime",
            "Index" => "Indeks",
            "Course" => "Smjer",
            _ => name
        };
    }
}
