using Client_Database_dot_net_lab_11_.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Database_dot_net_lab_11_
{
    public partial class FormMain : Form
    {
        private readonly string connectionString = "Host=localhost;Username=postgres;Password=sasha;Database=postgres";
        public FormMain()
        {
            InitializeComponent();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonDeleteSportsman_Click(object sender, EventArgs e)
        {
            try
            {
                Sportsman.Delete(connectionString, Convert.ToInt32(listViewSportsman.SelectedItems[0].SubItems[0].Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}