


namespace FreshVeggies.Models
{
    public partial class Buyer : IRealmObject
    {


        private Buyer()
        {
        }

        public Buyer(string appUserId, string name, string phone, string email, string ageGroup, Address address)
        {
            AppUserId = appUserId;
            Name = name;
            Phone = phone;
            Email = email;
            AgeGroup = ageGroup;
            Address = address;
        }

        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("appUser_id")]
        public string AppUserId { get; set; }


        [MapTo("name")]
        public string Name { get; set; }


        [MapTo("phone")]
        public string Phone { get; set; }


        [MapTo("email")]
        public string Email { get; set; }

        [MapTo("ageGroup")]
        public string AgeGroup { get; set; }

        [MapTo("address")]
        public Address? Address { get; set; }

        // local

        public string PhoneCode { get; } = "+91";
    }
}
