using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Netshoes.Api.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TransportResource {
    
    
    [DataMember(Name="trackingNumber", EmitDefaultValue=false)]
    public string TrackingNumber { get; set; }

    
    
    [DataMember(Name="trackingLink", EmitDefaultValue=false)]
    public string TrackingLink { get; set; }

    
    
    [DataMember(Name="trackingShipDate", EmitDefaultValue=false)]
    public DateTime? TrackingShipDate { get; set; }

    
    
    [DataMember(Name="deliveryDate", EmitDefaultValue=false)]
    public DateTime? DeliveryDate { get; set; }

    
    
    [DataMember(Name="shipDate", EmitDefaultValue=false)]
    public DateTime? ShipDate { get; set; }

    
    
    [DataMember(Name="deliveryService", EmitDefaultValue=false)]
    public string DeliveryService { get; set; }

    
    
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    public string Carrier { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransportResource {\n");
      
      sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
      
      sb.Append("  TrackingLink: ").Append(TrackingLink).Append("\n");
      
      sb.Append("  TrackingShipDate: ").Append(TrackingShipDate).Append("\n");
      
      sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
      
      sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
      
      sb.Append("  DeliveryService: ").Append(DeliveryService).Append("\n");
      
      sb.Append("  Carrier: ").Append(Carrier).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
