using Client_Database_dot_net_lab_11_.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Database_dot_net_lab_11_
{
    public partial class FormMain : Form
    {
        //postgres connection
        private readonly string connectionString = "Host=;Username=;Password=;Database=";
        public FormMain()
        {
            InitializeComponent();
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void toolStripButtonSelectSportsman_Click(object sender, EventArgs e)
        {
            var sportsmanList = Sportsman.Select(connectionString);
            listViewSportsman.Items.Clear();
            for (int i = 0; i < sportsmanList.Count; ++i){
                var sportsman = sportsmanList[i];
                var listViewItem = listViewSportsman.Items.Add(sportsman.Id.ToString());
                listViewItem.Tag = sportsman;
                listViewItem.SubItems.Add(sportsman.FirstName);
                if (sportsman.MiddleName != null)
                    listViewItem.SubItems.Add(sportsman.MiddleName);
                else 
                    listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(sportsman.LastName);
                if (sportsman.SportClub != null)
                    listViewItem.SubItems.Add(sportsman.SportClub.ToString());
                else
                    listViewItem.SubItems.Add("");
            }
        }

        private void toolStripButtonInsertSportsman_Click(object sender, EventArgs e)
        {
            FormSportsman formSportsman = new FormSportsman
            {
                Sportsman = new Sportsman()
            };
            if (formSportsman.ShowDialog() == DialogResult.OK)
                Sportsman.Insert(connectionString, formSportsman.Sportsman);
        }
        private void toolStripButtonUpdateSportsman_Click(object sender, EventArgs e)
        {
            try
            {
                FormSportsman formSportsman = new FormSportsman()
                {
                    Sportsman = (Sportsman)listViewSportsman.SelectedItems[0].Tag
                }; 
                if (formSportsman.ShowDialog() == DialogResult.OK)
                    Sportsman.Update(connectionString, formSportsman.Sportsman);
            }
            catch 
            {
                MessageBox.Show("Не выбрана строка");
            }
        }

        private void toolStripButtonDeleteSportsman_Click(object sender, EventArgs e)
        {
            try
            {
                Sportsman.Delete(connectionString, Convert.ToInt32(listViewSportsman.SelectedItems[0].SubItems[0].Text));
            }
            catch 
            {
                MessageBox.Show("Не выбрана строка");
            }
        }

        private void listViewSportsman_Click(object sender, EventArgs e)
        {
            Sportsman sportsman = (sender as ListView).SelectedItems[0].Tag as Sportsman;
            if (sportsman.Photo == null)
            {
                pictureBoxPlayer.Image = null;
                return;
            }
            try
            {
                using (var memoryStream = new MemoryStream(sportsman.Photo))
                {
                    pictureBoxPlayer.Image = Image.FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonSelectSportClub_Click(object sender, EventArgs e)
        {
            var sportClubList = SportClub.Select(connectionString);
            listViewSportClub.Items.Clear();
            for (int i = 0; i < sportClubList.Count; ++i)
            {
                var sportClub = sportClubList[i];
                var listViewItem = listViewSportClub.Items.Add(sportClub.Id.ToString());
                listViewItem.Tag = sportClub;
                listViewItem.SubItems.Add(sportClub.Title);
            }
        }

        private void toolStripButtonInsertSportClub_Click(object sender, EventArgs e)
        {
            FormSportClub formSportClub = new FormSportClub
            {
                SportClub = new SportClub()
            };
            if (formSportClub.ShowDialog() == DialogResult.OK)
                SportClub.Insert(connectionString, formSportClub.SportClub);
        }

        private void toolStripButtonUpdateSportClub_Click(object sender, EventArgs e)
        {
            try
            {
                FormSportClub formSportClub = new FormSportClub()
                {
                    SportClub = (SportClub)listViewSportClub.SelectedItems[0].Tag
                };
                if (formSportClub.ShowDialog() == DialogResult.OK)
                    SportClub.Update(connectionString, formSportClub.SportClub);
            }
            catch 
            {
                MessageBox.Show("Не выбрана строка");
            }
        }

        private void toolStripButtonDeleteSportClub_Click(object sender, EventArgs e)
        {
            try
            {
                SportClub.Delete(connectionString, Convert.ToInt32(listViewSportClub.SelectedItems[0].SubItems[0].Text));
            }
            catch
            {
                MessageBox.Show("Не выбрана строка");
            }
        }
    }
}