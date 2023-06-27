using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkChatBot
{
    public class BotUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PeerId { get; set; }
        public int IdRole { get; set; }

        public BotUser(
            int id,
            string name,
            long peerId,
            int idRole)
        {
            Id = id;
            Name = name;
            PeerId = peerId;
            IdRole = idRole;
        }
    }

    public class BotRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BotRole(
            int id,
            string name)
        {
            Id = id;
            Name = name;
        }
    }

    internal class BDconnection
    {
        private readonly string connectionString =
            "SERVER=localhost;" +
            "DATABASE=acs_db_prototype;" +
            "UID=root;" +
            "PASSWORD=4443;";

        public void AddBotUser(BotUser entity)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                throw new Exception("Database connection error.");
            }

            MySqlCommand command = new MySqlCommand
            {
                Connection = con,

                CommandText =
                $"insert into bot_users " +
                $"(name, peer_id, id_role) values " +
                $"('{entity.Name}', '{entity.PeerId}', '{entity.IdRole}');"
            };

            command.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteBotUser(int id)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                throw new Exception("Database connection error.");
            }   

            MySqlCommand command = new MySqlCommand
            {
                Connection = con,

                CommandText = $"delete from bot_users where id = '{id}';"
            };

            command.ExecuteNonQuery();
            con.Close();
        }

        public List<BotUser> SelectBotUsers()
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                throw new Exception("Database connection error.");
            }

            MySqlCommand command = new MySqlCommand
            {
                Connection = con,

                CommandText =
                "select *" +
                "from bot_users;"
            };

            var reader = command.ExecuteReader();

            List<BotUser> botUsers = new List<BotUser>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BotUser botUser = new BotUser(
                        id: Convert.ToInt32(reader["id"].ToString()),
                        name: reader["name"].ToString(),
                        peerId: Convert.ToInt64(reader["peer_id"].ToString()),
                        idRole: Convert.ToInt32(reader["id_role"].ToString()));
                    botUsers.Add(botUser);
                }

                reader.Close();
            }

            con.Close();
            return botUsers;
        }

        public void AddBotRole(BotRole entity)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                throw new Exception("Database connection error.");
            }

            MySqlCommand command = new MySqlCommand
            {
                Connection = con,

                CommandText =
                $"insert into bot_roles " +
                $"(name) values " +
                $"('{entity.Name}');"
            };

            command.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteBotRole(int id)
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                throw new Exception("Database connection error.");
            }

            MySqlCommand command = new MySqlCommand
            {
                Connection = con,

                CommandText = $"delete from bot_roles where id = '{id}';"
            };

            command.ExecuteNonQuery();
            con.Close();
        }

        public List<BotRole> SelectBotRoles()
        {
            MySqlConnection con = new MySqlConnection(connectionString);

            con.Open();
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                throw new Exception("Database connection error.");
            }

            MySqlCommand command = new MySqlCommand
            {
                Connection = con,

                CommandText =
                "select *" +
                "from bot_roles;"
            };

            var reader = command.ExecuteReader();

            List<BotRole> botRoles = new List<BotRole>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BotRole botRole = new BotRole(
                        id: Convert.ToInt32(reader["id"].ToString()),
                        name: reader["name"].ToString());
                    botRoles.Add(botRole);
                }

                reader.Close();
            }

            con.Close();
            return botRoles;
        }
    }
}
