using System.Runtime.Serialization;

namespace Ecommerce.Models
{
    //[Serialization]
    public class Product
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Picture {get; set;}
        [DataMember]
        public int Price {  get; set;}
        [DataMember]
        public int Quantity {  get; set;}
    }
}
