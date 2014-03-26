using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Namespace = "http://edisoftwebservices.com/")]
    public class ReceiverDto : GenericEntityDto
    {
        [DataMember(Order = 0)] public string Name1 { get; set; }
        [DataMember(Order = 1)] public string Name2 { get; set; }
        [DataMember(Order = 2)] public string PostalCode { get; set; }
        [DataMember(Order = 3)] public string StreetAddress1 { get; set; }
        [DataMember(Order = 4)] public string StreetAddress2 { get; set; }
        [DataMember(Order = 5)] public string Phone { get; set; }
        [DataMember(Order = 6)] public string City { get; set; }
        [DataMember(Order = 7)] public string ReceiverCustomerNumber { get; set; }
        [DataMember(Order = 8)] public string CountryIso { get; set; }
        [DataMember(Order = 9)] public string Attention { get; set; }
        [DataMember(Order = 10)] public string Mobile { get; set; }
        [DataMember(Order = 11)] public string Email { get; set; }
    }
}