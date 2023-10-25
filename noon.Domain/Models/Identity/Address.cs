using noon.Domain.Models.Order;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noon.Domain.Models.Identity
{
    public class Address
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string? Region { get; set; }
        public string? Governorate { get; set; }
        public string? City { get; set; }
        public string? street { get; set; }
        public string? building { get; set; }
        public string? near { get; set; }
        public string? lat { get; set; }
        public string? lng { get; set; }
        public string phoneNumber { get; set; }
        public bool isHome { get; set; }

        public virtual List<UserAddress>? UserAddresses { get; set; }
    }

  
}