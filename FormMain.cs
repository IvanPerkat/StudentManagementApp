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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedIndex >= 0)
            {
                text = "Želite li obrisati studenta?";
                caption = "Obriši studenta";
                buttons = MessageBoxButtons.YesNo;
                icon = MessageBoxIcon.Warning;

                DialogResult result = MessageBox.Show(text, caption, buttons, icon);

                switch (result)
                {
                    case DialogResult.Yes:
                        if (listBoxStudents.SelectedItem != null)
                        {
                            listBoxStudents.Items.Remove(listBoxStudents.SelectedItem);
                        }
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                text = "Odaberite studenta za brisanje!";
                caption = "Obriši studenta";
                buttons = MessageBoxButtons.OK;
                icon = MessageBoxIcon.Warning;

                DialogResult result = MessageBox.Show(text, caption, buttons, icon);
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.Items.Count > 0)
            {
                text = "Želite li izbrisati sve studente?";
                caption = "Brisanje svih studenata";
                buttons = MessageBoxButtons.YesNo;
                icon = MessageBoxIcon.Warning;

                DialogResult result = MessageBox.Show(text, caption, buttons, icon);

                switch (result)
                {
                    case DialogResult.Yes:
                        listBoxStudents.Items.Clear();
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                text = "Nema studenata za brisanje!";
                caption = "Brisanje svih studenata";
                buttons = MessageBoxButtons.OK;
                icon = MessageBoxIcon.Warning;

                MessageBox.Show(text, caption, buttons, icon);
            }
        }
    }
}
