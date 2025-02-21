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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Student? Student { get; set; }

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {
                        string emptyTextBox = textBox.Name.Replace("textBox", "");
                        string traslatedName = TranslatedNames(emptyTextBox);

                        text = $"{traslatedName} nema vrijednost!";
                        caption = "Greška pri upisivanju";
                        buttons = MessageBoxButtons.OK;
                        icon = MessageBoxIcon.Warning;

                        MessageBox.Show(text, caption, buttons, icon);
                    }
                    else
                    {
                        Student = new Student(
                            textBoxName.Text,
                            textBoxSurname.Text,
                            textBoxIndex.Text
                            );

                        DialogResult = DialogResult.Yes;

                        Close();
                    }
                }
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
            _ => name
        };
    }
}
