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
  public class ErrorResource {
    
    
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    
    [DataMember(Name="notifications", EmitDefaultValue=false)]
    public List<string> Notifications { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorResource {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  Notifications: ").Append(Notifications).Append("\n");
      
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
