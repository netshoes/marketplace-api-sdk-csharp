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
  public class InvoiceResource {
    
    
    [DataMember(Name="accessKey", EmitDefaultValue=false)]
    public string AccessKey { get; set; }

    
    
    [DataMember(Name="date", EmitDefaultValue=false)]
    public DateTime? Date { get; set; }

    
    
    [DataMember(Name="shipDate", EmitDefaultValue=false)]
    public DateTime? ShipDate { get; set; }

    
    
    [DataMember(Name="url", EmitDefaultValue=false)]
    public string Url { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceResource {\n");
      
      sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
      
      sb.Append("  Date: ").Append(Date).Append("\n");
      
      sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
      
      sb.Append("  Url: ").Append(Url).Append("\n");
      
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
