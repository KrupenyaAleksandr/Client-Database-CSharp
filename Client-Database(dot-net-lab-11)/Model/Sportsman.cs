using System;
using System.Collections.Generic;
using Npgsql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NpgsqlTypes;

namespace Client_Database_dot_net_lab_11_.Model
{
    public class Sportsman
    {
        private static readonly string selectSportsmansCommand =
            @"SELECT sportsman.id, sportsman.first_name, sportsman.middle_name, sportsman.last_name, sport_club.title
            FROM schema_sport.sportsman
            JOIN schema_sport.sport_club ON sportsman.sport_club_id = sport_club.id";

        private static string insertSportsmanCommand =
            @"INSERT INTO schema_sport.sportsman (first_name, middle_name, last_name, sport_club_id) VALUES
            (@first_name, @middle_name, @last_name, @sport_club_id)";

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; } = null;
        public string LastName { get; set; }
        public byte[] Photo { get; set; } = null;
        public string SportClub { get; set; } 
        public static List<Sportsman> Select(string connectionString)
        {
            List<Sportsman> sportsmanList = new List<Sportsman>();
            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    pgsqlConnection.Open();
                    using (var pgsqlCommand = new NpgsqlCommand(selectSportsmansCommand, pgsqlConnection))
                    {
                        using (var pgsqlReader = pgsqlCommand.ExecuteReader())
                        {
                            while (pgsqlReader.Read())
                            {
                                Sportsman sportsman = new Sportsman();
                                sportsman.Id = pgsqlReader.GetInt32(0);
                                sportsman.FirstName = pgsqlReader.GetString(1);
                                if (!pgsqlReader.IsDBNull(2))
                                    sportsman.MiddleName = pgsqlReader.GetString(2);
                                sportsman.LastName = pgsqlReader.GetString(3);
                                if (!pgsqlReader.IsDBNull(4))
                                    sportsman.SportClub = pgsqlReader.GetString(4);
                                sportsmanList.Add(sportsman);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    pgsqlConnection?.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pgsqlConnection?.Close();
                }
            }
            return sportsmanList;
        }

        public static void Insert(string connectionString, Sportsman sportsman)
        {
            int tmpSportClubId = -1;
            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    pgsqlConnection.Open();
                    using (var pgsqlCommand = new NpgsqlCommand(string.Format("SELECT sport_club.id FROM schema_sport.sport_club WHERE sport_club.title = '{0}'", 
                        sportsman.SportClub), pgsqlConnection))
                    {
                        try
                        {
                            using (var pgsqlReader = pgsqlCommand.ExecuteReader())
                            {
                                while (pgsqlReader.Read())
                                {
                                    tmpSportClubId = pgsqlReader.GetInt32(0);
                                }
                                if (tmpSportClubId == -1)
                                {
                                    throw new Exception();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format("Команда отсутствует в базе. {0}",ex.Message));
                            pgsqlConnection.Close();
                            return;
                        }
                    }
                    using (var pgsqlCommand = new NpgsqlCommand(insertSportsmanCommand, pgsqlConnection))
                    {
                        pgsqlCommand.Parameters.AddWithValue("@first_name", sportsman.FirstName);
                        pgsqlCommand.Parameters.AddWithValue("@middle_name", sportsman.MiddleName);
                        pgsqlCommand.Parameters.AddWithValue("@last_name", sportsman.LastName);
                        pgsqlCommand.Parameters.AddWithValue("@sport_club_id", tmpSportClubId);
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    pgsqlConnection?.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pgsqlConnection?.Close();
                }
            }
        }

    }
}