
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
