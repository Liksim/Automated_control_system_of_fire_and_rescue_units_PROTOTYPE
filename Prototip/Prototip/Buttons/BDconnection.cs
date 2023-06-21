using MySql.Data.MySqlClient;
using System.Data;

namespace Prototip.Buttons
{
    public class RescueEquipmentButton
    {
        public static Dictionary<Keys, string> HotKeys = new Dictionary<Keys, string>()
        {
            {Keys.F1, "F1"},
            {Keys.F2, "F2"},
            {Keys.F3, "F3"},
            {Keys.F4, "F4"},
            {Keys.F5, "F5"},
            {Keys.F6, "F6"},
            {Keys.F7, "F7"},
            {Keys.F8, "F8"},
            {Keys.F9, "F9"},
            {Keys.F10, "F10"},
            {Keys.F11, "F11"},
            {Keys.F12, "F12"}
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public string Voicing { get; set; }
        public string HotKey { get; set; }

        public RescueEquipmentButton(
            int id,
            string name,
            string voicing,
            string hotKey)
        {
            Id = id;
            Name = name;
            Voicing = voicing;
            HotKey = hotKey;
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
                $"insert into rescue_equipment_buttons " +
                $"(name, voicing, hotkey) values " +
                $"('{entity.Name}', '{entity.Voicing}', '{entity.HotKey}');"
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

                CommandText = $"delete from rescue_equipment_buttons where id = '{id}';"
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
                        voicing: reader["voicing"].ToString(),
                        hotKey: reader["hotKey"].ToString());
                    buttons.Add(button);
                }

                reader.Close();
            }

            con.Close();
            return buttons;
        }
    }
}
