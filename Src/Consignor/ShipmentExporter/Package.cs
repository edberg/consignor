﻿using System.Runtime.Serialization;

namespace Consignor.ShipmentExporter
{
    [DataContract(Name = "Package", Namespace = "http://schemas.datacontract.org/2004/07/EdiSoft.Common.Domain.ExportDomain")]
    public partial class Package
    {
        [DataMember(EmitDefaultValue = false)]
        public string Barcode1 { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Barcode2 { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Detail[] Details { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Event[] Events { get; set; }
        [DataMember]
        public int ItemNumber { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Reference[] References { get; set; }
    }
}
