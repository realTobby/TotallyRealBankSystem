using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBS_Prototype.Models
{
    public class PersonalData
    {
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public Dictionary<int, AddressData> Addresses { get; set; }
    }
}
