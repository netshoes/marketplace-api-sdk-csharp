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
  public class StockResponse {
    
    
    [DataMember(Name="country", EmitDefaultValue=false)]
    public string Country { get; set; }

    
    
    [DataMember(Name="available", EmitDefaultValue=false)]
    public long? Available { get; set; }

    
    
    [DataMember(Name="total", EmitDefaultValue=false)]
    public long? Total { get; set; }

    
    
    [DataMember(Name="reserved", EmitDefaultValue=false)]
    public long? Reserved { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StockResponse {\n");
      
      sb.Append("  Country: ").Append(Country).Append("\n");
      
      sb.Append("  Available: ").Append(Available).Append("\n");
      
      sb.Append("  Total: ").Append(Total).Append("\n");
      
      sb.Append("  Reserved: ").Append(Reserved).Append("\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
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
