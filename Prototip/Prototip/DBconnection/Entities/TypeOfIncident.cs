using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototip.DBconnection.Entities
{
    [Table("types_of_incident")]
    public class TypeOfIncident : Entity
    {        
        public string Name { get; set; }

        [Column("id_global_settings")]
        public int IdGlobalSettings { get; set; }   

        public TypeOfIncident() { }
        public TypeOfIncident(
            string name,
            int idGlobalSettings)
        {
            Name = name;
            IdGlobalSettings = idGlobalSettings;
        }
    }
}
