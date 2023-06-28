using System.ComponentModel.DataAnnotations.Schema;

namespace Prototip.DBconnection.Entities
{
    [Table("ppd_type")]
    public class PPDType : Entity
    {
        public string Name { get; set; }

        public PPDType() { }
        public PPDType(string name)
        {
            Name = name;
        }
    }
}
