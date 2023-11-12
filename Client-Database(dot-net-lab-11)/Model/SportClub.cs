using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Database_dot_net_lab_11_.Model
{
    public class SportClub
    {
        private static readonly string selectSportClubsCommand =
            @"SELECT sport_club.id, sport_club.title
            FROM schema_sport.sport_club";

        private static readonly string insertSportClubCommand =
            @"INSERT INTO schema_sport.sport_club (title) VALUES (@title)";

        private static readonly string updateSportClubCommand =
            @"UPDATE schema_sport.sport_club SET title = @title WHERE id = @id";

        private static readonly string deleteSportClubCommand =
            @"DELETE FROM schema_sport.sport_club WHERE id = @id";
        public int Id { get; set; }
        public string Title { get; set; }

        public static List<SportClub> Select(string connectionString)
        {
            List<SportClub> sportClubList = new List<SportClub>();
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(selectSportClubsCommand, npgsqlConnection))
                    {
                        using (var npgsqlReader = npgsqlCommand.ExecuteReader())
                        {
                            while (npgsqlReader.Read())
                            {
                                SportClub sportClub = new SportClub();
                                sportClub.Id = npgsqlReader.GetInt32(0);
                                sportClub.Title = npgsqlReader.GetString(1);
                                sportClubList.Add(sportClub);
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
            return sportClubList;
        }

        public static void Insert(string connectionString, SportClub sportClub)
        {
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(insertSportClubCommand, npgsqlConnection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@title", sportClub.Title);
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

        public static void Update(string connectionString, SportClub sportClub)
        {
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(updateSportClubCommand, npgsqlConnection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@title", sportClub.Title);
                        npgsqlCommand.Parameters.AddWithValue("@id", sportClub.Id);
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
        public static void Delete(string connectionString, int sportClubId)
        {
            using (var npgsqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgsqlConnection.Open();
                    using (var npgsqlCommand = new NpgsqlCommand(deleteSportClubCommand, npgsqlConnection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@id", sportClubId);
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
    }
}
