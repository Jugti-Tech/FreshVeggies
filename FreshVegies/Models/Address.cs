

namespace FreshVeggies.Models
{
    public partial class Address: IEmbeddedObject
    {

        private Address()
        {
        }

        public Address(string street, string city, string state, string zip, string country)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }

        [MapTo("street")]
        public string Street { get; set; }

        [MapTo("city")]
        public string City { get; set; }

        [MapTo("state")]
        public string State { get; set; }

        [MapTo("zip")]
        public string Zip { get; set; }

        [MapTo("country")]
        public string Country { get; set; }

    }
}
