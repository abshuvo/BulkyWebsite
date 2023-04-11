using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models
{
    public class Customer
    {
        [DisplayName ("Customer_Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

