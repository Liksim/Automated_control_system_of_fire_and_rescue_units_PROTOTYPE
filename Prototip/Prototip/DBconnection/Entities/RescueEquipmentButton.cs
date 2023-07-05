using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Prototip.DBconnection.Entities
{
    [Table("rescue_equipment_buttons")]
    public class RescueEquipmentButton : Entity
    {
        [IgnoreDataMember]
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
            {Keys.F11, "F11"}/*,
            {Keys.F12, "F12"}*/
        };

        public string Name { get; set; }
        public string Voicing { get; set; }
        public string HotKey { get; set; }

        [Column("id_department")]
        public int IdDepartment { get; set; }

        public RescueEquipmentButton() { }
        public RescueEquipmentButton(
            string name,
            string voicing,
            string hotKey,
            int idDepartment)
        {
            Name = name;
            Voicing = voicing;
            HotKey = hotKey;
            IdDepartment = idDepartment;
        }
    }
}
