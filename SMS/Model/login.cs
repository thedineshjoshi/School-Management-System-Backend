using System.ComponentModel.DataAnnotations;

namespace SMS.Model
{
    public class login
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
