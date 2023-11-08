using Client_Database_dot_net_lab_11_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Sportsman.FirstName = textBoxFirstName.Text;
            Sportsman.MiddleName = textBoxMiddleName.Text;
            Sportsman.LastName = textBoxLastName.Text;
            Sportsman.SportClub = textBoxSportClubId.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
