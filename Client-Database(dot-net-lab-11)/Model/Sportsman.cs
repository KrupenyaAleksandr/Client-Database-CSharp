using System;
using System.Collections.Generic;
using Npgsql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Database_dot_net_lab_11_.Model
{
    public class Sportsman
    {
        private static readonly string selectSportsmansCommand =
            @"SELECT sportsman.id, sportsman.first_name, sportsman.middle_name, sportsman.last_name, sport_club.title 
            FROM schema_sport.sportsman
            JOIN schema_sport.sport_club ON sportsman.sport_club_id = sport_club.id";
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
                finally
                {
                    pgsqlConnection?.Close();
                }
            }
            return sportsmanList;
        }

    }
}