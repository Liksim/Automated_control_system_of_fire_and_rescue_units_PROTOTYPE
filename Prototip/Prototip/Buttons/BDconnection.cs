using MySql.Data.MySqlClient;
using System.Data;

namespace Prototip.Buttons
{
    public class RescueEquipmentButtons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Voicing { get; set; }

        public RescueEquipmentButtons(
            int id,
            string name,
            string voicing)
        {
            Id = id;
            Name = name;
            Voicing = voicing;
        }
    }
    public class BDconnection
    {
        private readonly string connectionString =
            "SERVER=localhost;" +
            "DATABASE=mydatabase;" +
            "UID=testuser;" +
            "PASSWORD=testpassword;";

        public void AddButton(RescueEquipmentButtons entity)
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
                $"insert into buttons " +
                $"(name, voicing) values " +
                $"('{entity.Name}', '{entity.Voicing}');"
            };

            command.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteButton(int id)
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

                CommandText = $"delete from buttons where id = '{id}';"
            };

            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
