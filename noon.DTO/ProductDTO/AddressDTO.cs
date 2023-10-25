using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noon.DTO.ProductDTO
{
    public class AddressDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Region { get; set; }
        public string Governorate { get; set; }
        public string City { get; set; }
        public string street { get; set; }
        public string building { get; set; }
        public string near { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string phoneNumber { get; set; }
        public bool isHome { get; set; }
    }
}
