using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SMS.Model
{
    public class Register
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
