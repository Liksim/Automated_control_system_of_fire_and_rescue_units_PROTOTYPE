using System.ComponentModel.DataAnnotations.Schema;

namespace Prototip.DBconnection.Entities
{
    public class PPD : Entity
    {
        [Column("organization_name")]
        public string OrganizationName { get; set; }

        public string Address { get; set; }

        [Column("number_in_departament")]
        public int NumberInDepartament { get; set; }

        public int IdPPDType { get; set; }

        [Column("id_department")]
        public int IdDepartment { get; set; }

        public PPD() { }
        public PPD(
            string organizationName,
            string address,
            int numberInDepartament,
            int idPPDType,
            int idDepartment)
        {
            OrganizationName = organizationName;
            Address = address;
            NumberInDepartament = numberInDepartament;
            IdPPDType = idPPDType;
            IdDepartment = idDepartment;
        }
    }
}
