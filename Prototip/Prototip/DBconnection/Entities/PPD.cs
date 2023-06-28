using System.ComponentModel.DataAnnotations.Schema;

namespace Prototip.DBconnection.Entities
{
    [Table("ppd")]
    public class PPD : Entity
    {
        [Column("organization_name")]
        public string OrganizationName { get; set; }

        public string Address { get; set; }

        [Column("number_in_departament")]
        public int NumberInDepartament { get; set; }

        [Column("id_ppd_type")]
        public int IdPPDType { get; set; }

        public PPD() { }
        public PPD(
            string organizationName,
            string address,
            int numberInDepartament,
            int idPPDType)
        {
            OrganizationName = organizationName;
            Address = address;
            NumberInDepartament = numberInDepartament;
            IdPPDType = idPPDType;
        }
    }
}
