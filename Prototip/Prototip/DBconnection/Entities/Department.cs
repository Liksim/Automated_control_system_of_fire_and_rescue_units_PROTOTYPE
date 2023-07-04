using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototip.DBconnection.Entities
{
    [Table("departments")]
    public class Department : Entity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        [Column("settings_password")]
        public string SettingsPassword { get; set; }

        public Department() { }
        public Department(
            string login,
            string password,
            string settingsPassword)
        {
            Login = login;
            Password = password;
            SettingsPassword = settingsPassword;
        }
    }
}
