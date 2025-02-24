using System.Diagnostics;
using System.IO;

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

            pictureBoxAccdb.Tag = "MSACCESS.EXE";
            pictureBoxDocx.Tag = "WINWORD.EXE";
            pictureBoxXlsx.Tag = "EXCEL.EXE";
            pictureBoxPptx.Tag = "POWERPNT.EXE";

            pictureBoxAccdb.Click += OpenApp_Click;
            pictureBoxDocx.Click += OpenApp_Click;
            pictureBoxXlsx.Click += OpenApp_Click;
            pictureBoxPptx.Click += OpenApp_Click;
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

        private void pictureBoxEdge_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "msedge.exe",
                UseShellExecute = true
            });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "students.txt");

            StreamWriter saveFile = new StreamWriter(savePath);

            foreach (var student in listBoxStudents.Items)
            {
                saveFile.WriteLine(student);
            }

            saveFile.Close();

            text = "Lista studenata spremljena!";
            caption = "Spremljeno";
            buttons = MessageBoxButtons.OK;
            icon = MessageBoxIcon.Information;

            MessageBox.Show(text, caption, buttons, icon);
        }

        private void listBoxStudents_DoubleClick(object sender, EventArgs e)
        {
            FormStudentDetails studentDetails = new();

            if (listBoxStudents.SelectedItem is not null)
            {
                studentDetails.ShowDialog();
            }
        }

        private void MenuItem_Closed(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                menuItem.ForeColor = Color.FromArgb(255, 255, 255, 255);
            }
        }

        private void MenuItem_Opend(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                menuItem.ForeColor = Color.FromArgb(255, 0, 138, 255);
            }
        }

        private void OpenApp_Click(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is string appName)
            {
                string appPath = $"C:/Program Files/Microsoft Office/root/Office16/{appName}";
                Process.Start(appPath);
            }
        }
    }
}
