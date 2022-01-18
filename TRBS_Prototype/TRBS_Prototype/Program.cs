using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBS_Prototype.Models;

namespace TRBS_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();

            acc.Holder = new PersonalData() { FirstName = "Max", LastName = "Mustermann", Email = "max.mustermann@trbs.io", PersonID = 0, TelephoneNumber = "123456789123", Addresses = new Dictionary<int, AddressData>() };

            acc.Holder.Addresses.Add(0, new AddressData() { Country = "Germany", State = "Berlin", City = "Berlin", Street = "Berliner Str.", Number = 24, ZipCode = "12345" });

            acc.Amount = 10000.00;

        }
    }
}
