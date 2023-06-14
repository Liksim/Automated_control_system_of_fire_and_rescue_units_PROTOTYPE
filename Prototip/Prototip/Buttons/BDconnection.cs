using MySql.Data.MySqlClient;
using System.Data;

namespace Prototip.Buttons
{
    public class RescueEquipmentButton
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Voicing { get; set; }

        public RescueEquipmentButton(
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
            "DATABASE=acs_db_prototype;" +
            "UID=root;" +
            "PASSWORD=4443;";

        public void AddButton(RescueEquipmentButton entity)
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

        public List<RescueEquipmentButton> SelectButtons()
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
                "from rescue_equipment_buttons;"
            };

            var reader = command.ExecuteReader();

            List<RescueEquipmentButton> buttons = new List<RescueEquipmentButton>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    RescueEquipmentButton button = new RescueEquipmentButton(
                        id: Convert.ToInt32(reader["id"].ToString()),
                        name: reader["name"].ToString(),
                        voicing: reader["voicing"].ToString());
                    buttons.Add(button);
                }

                reader.Close();
            }

            con.Close();
            return buttons;
        }
    }
}
