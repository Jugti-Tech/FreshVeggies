

namespace FreshVeggies.Models
{
    public partial class Vegetable: IRealmObject
    {
        private Vegetable()
        {

        }

        public Vegetable(string name, string description, byte[] image, double price, int unitOfPrice)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            UnitOfPrice = unitOfPrice;
        }

        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; }= ObjectId.GenerateNewId();

        [MapTo("name")]
        public string Name { get; set; }

        [MapTo("description")]
        public string Description { get; set; }

        [MapTo("image")]
        public byte[] Image { get; set; }

        [MapTo("price")]
        public double Price { get; set; }

        // the quantity on which the price is based
        [MapTo("unitOfPrice")]
        public int UnitOfPrice { get; set; }    

        
        // the below property does not sync. It is used to display the price in the UI
        public double DisplayPrice => Price / UnitOfPrice;
    }
}
