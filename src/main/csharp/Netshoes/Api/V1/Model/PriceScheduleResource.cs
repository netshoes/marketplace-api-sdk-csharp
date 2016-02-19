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
  public class PriceScheduleResource {
    
    
    [DataMember(Name="sku", EmitDefaultValue=false)]
    public string Sku { get; set; }

    
    
    [DataMember(Name="priceFrom", EmitDefaultValue=false)]
    public double? PriceFrom { get; set; }

    
    
    [DataMember(Name="priceTo", EmitDefaultValue=false)]
    public double? PriceTo { get; set; }

    
    
    [DataMember(Name="dateInit", EmitDefaultValue=false)]
    public DateTime? DateInit { get; set; }

    
    
    [DataMember(Name="dateEnd", EmitDefaultValue=false)]
    public DateTime? DateEnd { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PriceScheduleResource {\n");
      
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      
      sb.Append("  PriceFrom: ").Append(PriceFrom).Append("\n");
      
      sb.Append("  PriceTo: ").Append(PriceTo).Append("\n");
      
      sb.Append("  DateInit: ").Append(DateInit).Append("\n");
      
      sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
      
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
