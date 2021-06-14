using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{
    public class IndexViewModel
    {
        public Registration NewUser { get; set; }
        public Login CurrentUser { get; set; }
    }
}