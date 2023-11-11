using Client_Database_dot_net_lab_11_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Database_dot_net_lab_11_
{
    public partial class FormSportsman : Form
    {
        private Sportsman sportsman;
        public Sportsman Sportsman { 
            get { return sportsman; } 
            set
            {
                sportsman = value;
                textBoxFirstName.Text = sportsman.FirstName;
                textBoxMiddleName.Text = sportsman.MiddleName;
                textBoxLastName.Text = sportsman.LastName;
                textBoxSportClubId.Text = sportsman.SportClub;
            }
        }
        public FormSportsman()
        {
            InitializeComponent();
            openFileDialogImage.Filter = "Files|*.jpg;*.jpeg;*.png;";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Некорректное заполнение");
                return;
            }
            Sportsman.FirstName = textBoxFirstName.Text;
            Sportsman.MiddleName = textBoxMiddleName.Text;
            Sportsman.LastName = textBoxLastName.Text;
            Sportsman.SportClub = textBoxSportClubId.Text;
            DialogResult = DialogResult.OK;
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.Cancel)
                return;
            using (var memoryStream = new MemoryStream())
            {
                try
                {
                    Image tmpImage = Image.FromFile(openFileDialogImage.FileName);
                    tmpImage.Save(memoryStream, tmpImage.RawFormat);
                    Sportsman.Photo = memoryStream.ToArray();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
