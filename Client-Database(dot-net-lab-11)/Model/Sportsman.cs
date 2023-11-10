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
            LEFT JOIN schema_sport.sport_club ON sportsman.sport_club_id = sport_club.id";

        private static string insertSportsmanCommand =
            @"INSERT INTO schema_sport.sportsman (first_name, middle_name, last_name, sport_club_id) VALUES
            (@first_name, @middle_name, @last_name, @sport_club_id)";

        private static string updateSportsmanCommand =
            @"UPDATE schema_sport.sportsman SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name,
            sport_club_id = @sport_club_id WHERE id = @id";

        private static string deleteSportsmanCommand =
            @"DELETE FROM schema_sport.sportsman WHERE id=@id";

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
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            pgsqlConnection.Close();
                            return;
                        }
                    }
                    using (var pgsqlCommand = new NpgsqlCommand(insertSportsmanCommand, pgsqlConnection))
                    {
                        pgsqlCommand.Parameters.AddWithValue("@first_name", sportsman.FirstName);
                        if (sportsman.MiddleName == "") 
                            pgsqlCommand.Parameters.AddWithValue("@middle_name", DBNull.Value);
                        else 
                            pgsqlCommand.Parameters.AddWithValue("@middle_name", sportsman.MiddleName);
                        pgsqlCommand.Parameters.AddWithValue("@last_name", sportsman.LastName);
                        if (tmpSportClubId == -1)
                            pgsqlCommand.Parameters.AddWithValue("@sport_club_id", DBNull.Value);
                        else
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
        public static void Update(string connectionString, Sportsman sportsman)
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
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            pgsqlConnection.Close();
                            return;
                        }
                    }
                    using (var pgsqlCommand = new NpgsqlCommand(updateSportsmanCommand, pgsqlConnection))
                    {
                        pgsqlCommand.Parameters.AddWithValue("@first_name", sportsman.FirstName);
                        if (sportsman.MiddleName == "")
                            pgsqlCommand.Parameters.AddWithValue("@middle_name", DBNull.Value);
                        else
                            pgsqlCommand.Parameters.AddWithValue("@middle_name", sportsman.MiddleName);
                        pgsqlCommand.Parameters.AddWithValue("@last_name", sportsman.LastName);
                        if (tmpSportClubId == -1)
                            pgsqlCommand.Parameters.AddWithValue("@sport_club_id", DBNull.Value);
                        else
                            pgsqlCommand.Parameters.AddWithValue("@sport_club_id", tmpSportClubId);
                        pgsqlCommand.Parameters.AddWithValue("@id", sportsman.Id);
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
        public static void Delete(string connectionString, int id)
        {
            using (var pgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    pgsqlConnection.Open();
                    using (var pgsqlCommand = new NpgsqlCommand(deleteSportsmanCommand, pgsqlConnection))
                    {
                        pgsqlCommand.Parameters.AddWithValue("@id", id);
                        pgsqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
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