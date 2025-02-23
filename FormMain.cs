using System.Diagnostics;

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDownOpened += MenuItem_Opend;
            fileToolStripMenuItem.DropDownClosed += MenuItem_Closed;

            settingsToolStripMenuItem.DropDownOpened += MenuItem_Opend;
            settingsToolStripMenuItem.DropDownClosed += MenuItem_Closed;
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
                if (addStudent.Student is not null)
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
                        if (listBoxStudents.SelectedItem is not null)
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

        private void MenuItem_Opend(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                menuItem.ForeColor = Color.FromArgb(255, 0, 138, 255);
            }
        }

        private void MenuItem_Closed(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                menuItem.ForeColor = Color.FromArgb(255, 255, 255, 255);
            }
        }

        private void pictureBoxEdge_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "msedge.exe",
                UseShellExecute = true
            });
        }

        private void pictureBoxXlsx_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void pictureBoxDocx_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void pictureBoxPptx_Click(object sender, EventArgs e)
        {
            Process.Start("powerpnt.exe");
        }

        private void pictureBoxAccdb_Click(object sender, EventArgs e)
        {
            Process.Start("msaccess.exe");
        }
    }
}
