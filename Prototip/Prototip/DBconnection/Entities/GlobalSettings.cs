using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototip.DBconnection.Entities
{
    [Table("global_settings")]
    public class GlobalSettings : Entity
    {
        public string Name { get; set; }

        [Column("alert_location")]
        public string AlertLocation { get; set; }

        public GlobalSettings() { }
        public GlobalSettings(
            int id,
            string name,
            string alertLocation)
        {
            Id = id;
            Name = name;
            AlertLocation = alertLocation;
        }
    }
}
