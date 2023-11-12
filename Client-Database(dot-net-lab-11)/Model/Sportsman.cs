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
            @"SELECT sportsman.id, sportsman.first_name, sportsman.middle_name, sportsman.last_name, sportsman.photo, sport_club.title
            FROM schema_sport.sportsman
            LEFT JOIN schema_sport.sport_club ON sportsman.sport_club_id = sport_club.id";

        private static string insertSportsmanCommand =
            @"INSERT INTO schema_sport.sportsman (first_name, middle_name, last_name, photo, sport_club_id) VALUES
            (@first_name, @middle_name, @last_name, @photo, @sport_club_id)";

        private static string updateSportsmanCommand =
            @"UPDATE schema_sport.sportsman SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name,
            photo = @photo, sport_club_id = @sport_club_id WHERE id = @id";

        private static string deleteSportsmanCommand =
            @"DELETE FROM schema_sport.sportsman WHERE id=@id";

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; } = null;
        public string LastName { get; set; }
        public byte[] Photo { get; set; } = null;
        public string SportClub { get; set; } = null;
        public static List<Sportsman> Select(string connectionString)
        {
            List<Sportsman> sportsmanList = new List<Sportsman>();
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(selectSportsmansCommand, npgsqlConnection))
                    {
                        using (var npgsqlReader = npgsqlCommand.ExecuteReader())
                        {
                            while (npgsqlReader.Read())
                            {
                                Sportsman sportsman = new Sportsman();
                                sportsman.Id = npgsqlReader.GetInt32(0);
                                sportsman.FirstName = npgsqlReader.GetString(1);
                                if (!npgsqlReader.IsDBNull(2))
                                    sportsman.MiddleName = npgsqlReader.GetString(2);
                                sportsman.LastName = npgsqlReader.GetString(3);
                                if (!npgsqlReader.IsDBNull(4))
                                {
                                    sportsman.Photo = new byte[4194304];
                                    npgsqlReader.GetBytes(4, 0, sportsman.Photo, 0, 4194304);
                                }
                                if (!npgsqlReader.IsDBNull(5))
                                    sportsman.SportClub = npgsqlReader.GetString(5);
                                sportsmanList.Add(sportsman);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    npgsqlConnection?.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    npgsqlConnection?.Close();
                }
            }
            return sportsmanList;
        }

        public static void Insert(string connectionString, Sportsman sportsman)
        {
            int tmpSportClubId = -1;
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(string.Format("SELECT sport_club.id FROM schema_sport.sport_club WHERE sport_club.title = '{0}'", 
                        sportsman.SportClub), npgsqlConnection))
                    {
                        try
                        {
                            using (var npgsqlReader = npgsqlCommand.ExecuteReader())
                            {
                                while (npgsqlReader.Read())
                                {
                                    tmpSportClubId = npgsqlReader.GetInt32(0);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            npgsqlConnection.Close();
                            return;
                        }
                    }
                    using (var npgsqlCommand = new NpgsqlCommand(insertSportsmanCommand, npgsqlConnection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@first_name", sportsman.FirstName);
                        if (sportsman.MiddleName == "") 
                            npgsqlCommand.Parameters.AddWithValue("@middle_name", DBNull.Value);
                        else 
                            npgsqlCommand.Parameters.AddWithValue("@middle_name", sportsman.MiddleName);
                        npgsqlCommand.Parameters.AddWithValue("@last_name", sportsman.LastName);
                        if (sportsman.Photo == null)
                            npgsqlCommand.Parameters.AddWithValue("@photo", DBNull.Value);
                        else
                            npgsqlCommand.Parameters.AddWithValue("@photo", sportsman.Photo);
                        if (tmpSportClubId == -1)
                            npgsqlCommand.Parameters.AddWithValue("@sport_club_id", DBNull.Value);
                        else
                            npgsqlCommand.Parameters.AddWithValue("@sport_club_id", tmpSportClubId);
                        npgsqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    npgsqlConnection?.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    npgsqlConnection?.Close();
                }
            }
        }
        public static void Update(string connectionString, Sportsman sportsman)
        {
            int tmpSportClubId = -1;
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(string.Format("SELECT sport_club.id FROM schema_sport.sport_club WHERE sport_club.title = '{0}'",
                        sportsman.SportClub), npgsqlConnection))
                    {
                        try
                        {
                            using (var npgsqlReader = npgsqlCommand.ExecuteReader())
                            {
                                while (npgsqlReader.Read())
                                {
                                    tmpSportClubId = npgsqlReader.GetInt32(0);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            npgsqlConnection.Close();
                            return;
                        }
                    }
                    using (var npgsqlCommand = new NpgsqlCommand(updateSportsmanCommand, npgsqlConnection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@first_name", sportsman.FirstName);
                        if (sportsman.MiddleName == "")
                            npgsqlCommand.Parameters.AddWithValue("@middle_name", DBNull.Value);
                        else
                            npgsqlCommand.Parameters.AddWithValue("@middle_name", sportsman.MiddleName);
                        npgsqlCommand.Parameters.AddWithValue("@last_name", sportsman.LastName);
                        if (sportsman.Photo == null)
                            npgsqlCommand.Parameters.AddWithValue("@photo", DBNull.Value);
                        else
                            npgsqlCommand.Parameters.AddWithValue("@photo", sportsman.Photo);
                        if (tmpSportClubId == -1)
                            npgsqlCommand.Parameters.AddWithValue("@sport_club_id", DBNull.Value);
                        else
                            npgsqlCommand.Parameters.AddWithValue("@sport_club_id", tmpSportClubId);
                        npgsqlCommand.Parameters.AddWithValue("@id", sportsman.Id);
                        npgsqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    npgsqlConnection?.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    npgsqlConnection?.Close();
                }
            }
        }
        public static void Delete(string connectionString, int sportsmanId)
        {
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(deleteSportsmanCommand, npgsqlConnection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@id", sportsmanId);
                        npgsqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    npgsqlConnection?.Close();
                }
            }
        }
    }
}