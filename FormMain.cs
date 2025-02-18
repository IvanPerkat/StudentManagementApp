using System.Drawing.Text;

namespace StudentManagementApp
{
    public partial class FormMain : Form
    {
        private string text = "";
        private string caption = "";
        private MessageBoxButtons buttons;
        private MessageBoxIcon icon;

        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            text = "Želite li izaiæi iz aplikacije?";
            caption = "Izlazite iz aplikacije";
            buttons = MessageBoxButtons.YesNo;
            icon = MessageBoxIcon.Warning;

            DialogResult result = MessageBox.Show(text, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent addStudent = new();
            DialogResult result = addStudent.ShowDialog();

            if (result == DialogResult.Yes)
            {
                if (addStudent.Student != null)
                {
                    listBoxStudents.Items.Add(addStudent.Student.StudentDetails());
                }
            }
        }
    }
}
