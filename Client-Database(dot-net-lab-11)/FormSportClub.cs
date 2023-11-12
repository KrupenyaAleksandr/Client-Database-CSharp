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
    public partial class FormSportClub : Form
    {
        private SportClub sportClub;
        public SportClub SportClub
        {
            get { return sportClub; }
            set
            {
                sportClub = value;
                textBoxTitle.Text = sportClub.Title;
            }
        }
        public FormSportClub()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                MessageBox.Show("Некорректное заполнение");
                return;
            }
            SportClub.Title = textBoxTitle.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
